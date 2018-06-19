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
    public static GameObject cameraX;
    public static GameObject cameraY;

    /*
     * variable for user rotation
     */
    private Vector3 dragStart;
    private Quaternion quaternion;

    /*
     * save parameters
     */
    private static Vector3 cameraPosition;
    private float fieldOfViewCamera;

    /*
     * Static variale for camera
     */
    public static bool canRotate = true;
    public static bool canRotateX = true;
    public static bool canRotateY = true;

    /*
     * Others parameters
     */
    private static bool runToMainPosition = false;
    private static bool runToSpacePosition = false;

    static float t = 0.0f;

    // Use this for initialization
    void Start () {

        cameraX = transform.parent.gameObject;
        cameraY = cameraX.transform.parent.gameObject;

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

            if (canRotateY)
                cameraY.transform.Rotate(moveY);

            if (canRotateX)
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
            cameraX.transform.localEulerAngles = new Vector3(Mathf.Lerp(cameraX.transform.localEulerAngles.x, cameraPosition.x, t), 0, 0);

            t += 0.5f * Time.deltaTime;
            if (t > 1.0f)
            {
                runToMainPosition = false;
                canRotate = true;
                canRotateX = true;
                canRotateY = true;
                t = 0.0f;
            }
        }
        if (runToSpacePosition)
        {
            cameraX.transform.localEulerAngles = new Vector3(Mathf.Lerp(cameraX.transform.localEulerAngles.x, 90, t), 0, 0);

            t += 0.5f * Time.deltaTime;
            if (t > 1.0f)
            {
                runToSpacePosition = false;
                canRotate = true;
                canRotateX = false;
                canRotateY = true;
                t = 0.0f;
            }
        }
    }

    public static void RunToMainPosition()
    {
        runToSpacePosition = false;
        runToMainPosition = true;
 
    }

    public static void RunToSpacePosition()
    {
        cameraPosition = new Vector3(cameraX.transform.localEulerAngles.x, cameraY.transform.localEulerAngles.y, 0);
        runToMainPosition = false;
        runToSpacePosition = true;
    }
}
