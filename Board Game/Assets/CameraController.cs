using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float dragSpeedY = 10;
    public float dragSpeedX = 10;

    private Vector3 dragStart;
    private Quaternion quaternion;

    public GameObject cameraX;
    public GameObject cameraY;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            dragStart = Input.mousePosition;
            transform.rotation = quaternion;
            return;
        }

        if (!Input.GetMouseButton(0))
        {
            quaternion = transform.rotation;
            return;
        }

        Ray vector = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (!Physics.Raycast(vector, out hit))
        {
        }

        Vector3 posY = Camera.main.ScreenToViewportPoint((Input.mousePosition - dragStart) * dragSpeedY);
        Vector3 moveY = new Vector3(0, posY.x, 0);

        Vector3 posX = Camera.main.ScreenToViewportPoint((Input.mousePosition - dragStart) * dragSpeedX);
        Vector3 moveX = new Vector3(-posX.y, 0, 0);

        //transform.rotation = quaternion;
        cameraY.transform.Rotate(moveY);
        cameraX.transform.Rotate(moveX);

        //LimitRotatiion();
    }
    
    private void LimitRotatiion()
    {
        Vector3 vector = new Vector3( cameraX.transform.rotation.eulerAngles.x, 0, 0);

        if (cameraX.transform.rotation.eulerAngles.x < 10)
            vector.x = 10;
        if (cameraX.transform.rotation.eulerAngles.x > 90)
            vector.x = 90;

        cameraX.transform.rotation = Quaternion.EulerAngles(vector.x, 0, 0);
    }
}
