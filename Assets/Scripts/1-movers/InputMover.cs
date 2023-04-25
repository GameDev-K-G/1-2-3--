using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class InputMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 10f;
    // [SerializeField] float jumpSpeed = 20f;
    [SerializeField] InputAction moveHorizontal = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction moveVertical  = new InputAction(type: InputActionType.Button);
    // [SerializeField] InputAction jump  = new InputAction(type: InputActionType.Button);

    void OnEnable()  {
        moveHorizontal.Enable();
        moveVertical.Enable();
    }

    void OnDisable()  {
        moveHorizontal.Disable();
        moveVertical.Disable();
    }


    void Update() {
        float horizontal = moveHorizontal.ReadValue<float>();
        float vertical = moveVertical.ReadValue<float>();
        // if(Input.GetButtonDown("Jump")){
        //     Vector3 movementVector = new Vector3(horizontal, jumpSpeed,0);
        //     transform.position += movementVector;
        // }
        // else{
            Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
            transform.position += movementVector;
        // }
    }
}
