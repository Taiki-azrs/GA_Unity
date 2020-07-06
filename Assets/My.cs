using UnityEngine;
using System.Collections;

public class My : MonoBehaviour
{
   

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(1, 1, 1);
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 5; // カメラからの距離
            Vector3 pos2 = Camera.main.ScreenToWorldPoint(pos);
            transform.position = pos2;
        }
    }
}