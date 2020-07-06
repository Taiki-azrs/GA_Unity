using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(1, 1, 1);
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 5.0f; // カメラからの距離
            Vector3 pos2 = Camera.main.ScreenToWorldPoint(pos);
            transform.position = pos2;
        }
    }
}
