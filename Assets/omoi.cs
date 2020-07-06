using UnityEngine;
using System.Collections;

public class omoi : MonoBehaviour
{
    Material backup;
   public  Rigidbody tes;
    void Start()
    {
        tes = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        tes.AddForce(new Vector3(x, 0, y));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "base") return;
        backup = collision.gameObject.GetComponent<Renderer>().material;
        collision.gameObject.GetComponent<Renderer>().material = null;
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "base") return;
        collision.gameObject.GetComponent<Renderer>().material = backup;
    }
}