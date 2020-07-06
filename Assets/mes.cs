using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mes : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
      

    }



    // Update is called once per frame
    void Update()
    {
        Text Atext = GameObject.Find("message").GetComponent<Text>();
        transform.Rotate(1, 1, 1);
            Vector3 pos = Input.mousePosition;
            Atext.text = "x:" + pos.x + ", y:" + pos.y;

        
    }
}
