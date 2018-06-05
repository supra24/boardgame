using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    /*
     * Speed rotation (X and Y)
     */
    public float dragSpeedY = 10;
    public float dragSpeedX = 10;

    /*
     * Main object for rotation (X and Y)
     */
    public GameObject cameraX;
    public GameObject cameraY;

    /*
     * variable for user rotation
     */
    private Vector3 dragStart;
    private Quaternion quaternion;

    /*
     * save parameters
     */
    private Vector3 cameraPosition;
    private float fieldOfViewCamera;

    /*
     * Static variale for camera
     */
    public static bool canRotate = true;

    /*
     * Others parameters
     */
    private bool runToMainPosition = false;
    private bool runToSpacePosition = false;

    // Use this for initialization
    void Start () {

        cameraPosition = cameraY.transform.localPosition;
        fieldOfViewCamera = Camera.main.fieldOfView;
	}

    // Update is called once per frame
    void Update()
    {
        if (canRotate) // run when user can rotate board
        {
            if (Input.GetMouseButtonDown(0))
            {
                dragStart = Input.mousePosition;
                return;
            }

            if (!Input.GetMouseButton(0))
                return;

            Vector3 posY = Camera.main.ScreenToViewportPoint((Input.mousePosition - dragStart) * dragSpeedY);
            Vector3 moveY = new Vector3(0, posY.x, 0);

            Vector3 posX = Camera.main.ScreenToViewportPoint((Input.mousePosition - dragStart) * dragSpeedX);
            Vector3 moveX = new Vector3(-posX.y, 0, 0);

            cameraY.transform.Rotate(moveY);
            cameraX.transform.Rotate(moveX);

            LimitRotatiion();
        }
    }

    private void LimitRotatiion()
    {
        Vector3 vector = new Vector3( cameraX.transform.localEulerAngles.x, 0, 0);

        if (vector.x < 10)
            vector.x = 10;
        if (vector.x > 90)
            vector.x = 90;

        cameraX.transform.localEulerAngles = vector;
    }

    private void FixedUpdate()
    {
        if (runToMainPosition)
        {

        } 
        else if (runToSpacePosition)
        {

        }
    }

    public void RunToMainPosition()
    {
        runToMainPosition = true;
    }
}
