using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atarimin : MonoBehaviour
{
    ita x;
    public int scr = 0;
    public int hantei = 0;
    public int overhan = 0;
    public int k;
    time count;
    public int u = 0;
    public float r = 0.0f;

    // Use this for initialization
    void Start()
    {
        count = GameObject.Find("Text").GetComponent<time>();
    }

    // Update is called once per frame
    void Update()
    {
        
     x = transform.parent.transform.GetComponentInChildren<ita>();
        k = x.i;
        r = Vector3.Distance(transform.parent.FindChild("base").FindChild("atari").transform.position, transform.position);
        if (count.countTime > 19.5f && u == 0)
        {
            atari.score[x.i] -= (int)r;
            u = 1;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (hantei == 0)
        {
            if (collision.gameObject.name == "atari")
            {
                atari.score[k] += 1000;
                hantei = 1;
            }
            if (collision.gameObject.name == "syougai")
            {

                GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 10));
                GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 0));

            }
            if (collision.gameObject.name == "gameover" &&overhan==0) 
            {
                atari.score[k] -= 100;
                atari.score[x.i] -= 20 - (int)count.countTime;
                overhan = 1;

            }
        }
    }
}