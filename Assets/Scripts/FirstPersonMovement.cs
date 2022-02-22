using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class FirstPersonMovement : MonoBehaviour



{ //player movement directives

    public Vector3 direction;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    //OnPlayerMove event handler

    public void OnPlayerMove (InputValue value)
    {
        // a vector with x and y components responding to the players arrow and wasd components
        Vector2 inputVector = value.Get<Vector2>();

        direction.x = inputVector.x;
        direction.z = inputVector.y;

    }
}
