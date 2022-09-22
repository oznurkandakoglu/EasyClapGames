using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObjects : MonoBehaviour
{   
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("DropArea"))
        {
           GetComponent<FixedJoint>().connectedBody = null;                      
        }

        if (collision.collider.CompareTag("Collectable"))
        {
            collision.gameObject.GetComponent<FixedJoint>().connectedBody = GetComponent<Rigidbody>();
            collision.gameObject.tag = "Untagged";

        }
    }

}
