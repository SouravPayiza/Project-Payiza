using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // public void Jump()
    // {
    //     Debug.Log("Jumping!!!");
    //     rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
    // }


    //To know three different phases
    public void Jump(InputAction.CallbackContext context)
    {
        // Debug.Log("Jumping!!!" + context.phase);
        // rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);

        //Execution Only one phase
        Debug.Log(context);
        if (context.performed)
        {
            Debug.Log("Jumping!!!" + context.phase);
            rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }
    }
}
