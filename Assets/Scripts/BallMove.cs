using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Rigidbody rb;

    int layerPlayer = 6;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward*30f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = new Vector3();
        
        normal = collision.GetContact(0).normal;

        if(collision.collider.gameObject.layer == layerPlayer)
            rb.AddForce(normal);
        
    }

}
