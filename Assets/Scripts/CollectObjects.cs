using UnityEngine;

public class CollectObjects : MonoBehaviour
{   
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("DropArea"))
        {
            GetComponent<FixedJoint>().connectedBody = null;
            Destroy(GetComponent<FixedJoint>());
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if (collision.collider.CompareTag("Player"))
        {
            if(GetComponent<FixedJoint>() != null)
                GetComponent<FixedJoint>().connectedBody = collision.gameObject.GetComponent<Rigidbody>();
           

        }
    }

}
