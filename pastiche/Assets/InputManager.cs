using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public float CurrentInput;

    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;

    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;

    void Update()
    {
        if (Input.GetKeyUp(rightKey) == true || Input.GetKeyUp(leftKey) == true) {
            CurrentInput = 0;
        }

        if (Input.GetKeyDown(rightKey) == true)
        {
            CurrentInput = 1;

        }

        if (Input.GetKeyDown(leftKey) == true)
        {
        
            CurrentInput = -1;

        }
    }

    void FixedUpdate()
    {
        if (facingRight == false && CurrentInput > 0)
        {
            Flip();
        } else if (facingRight == true && CurrentInput < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
