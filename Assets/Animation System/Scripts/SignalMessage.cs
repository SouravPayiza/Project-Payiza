using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalMessage : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void AddForce()
    {
        rb.AddForce(Vector3.up * 50f,ForceMode.Impulse);
    }
}
