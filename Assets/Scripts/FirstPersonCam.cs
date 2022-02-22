using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCam : MonoBehaviour
{

    //the camera attached to the player

    public Camera playerCamera;

    //container variables for the mouse delta values each frame

    public float deltaX;
    public float deltaY;

    //container variables for the players rotation around the x and y axis in degrees

    public float xRot;
    public float Yrot;



    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main;//set player camera
        Cursor.visible = false;// hide player cursor
    }

    // Update is called once per frame
    void Update()
    {
        //keep track of the players x and y rotation

        Yrot += deltaX;
        xRot -= deltaY;

        // keep the players x rotation clamped to 90

        xRot = Mathf.Clamp(xRot, -90f, 90f);

        //rotate the camera around the x axis

        playerCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        transform.rotation = Quaternion.Euler(0, Yrot, 0);
    }
    //on camera look event handler 
    public void OnCameraLook(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        deltaX = inputVector.x;
        deltaY = inputVector.y;

    }
}

