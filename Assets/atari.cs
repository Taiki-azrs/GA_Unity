using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atari : MonoBehaviour
{
    ita x;
   public int a=0;
    public int hantei = 0;
    public int overhan = 0;
    public static int[] score = new int[8] { 0, 0, 0, 0, 0, 0, 0,0 };
    time count;
    public int K;
    public int s;
   public float r=0.0f;
    public int u=0;
   
   
    void Start()
    {
        count = GameObject.Find("Text").GetComponent<time>();
    }

    // Update is called once per frame
    void Update()
    {

        x = transform.parent.transform.GetComponentInChildren<ita>();
        K = x.i;
        r = Vector3.Distance(transform.parent.FindChild("base").FindChild("atari").transform.position, transform.position);
        if (count.countTime > 19.5f && u == 0)
        {
            score[x.i] -= (int)r;
            u = 1;
        }


    }
    public void OnCollisionEnter(Collision collision)
    {
        if (hantei == 0)
        {
            if (collision.gameObject.name == "atari")
            {
                score[K] += 1000;
                hantei = 1;
            }

        }
        if (collision.gameObject.name == "syougai")
        {
           GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 10));
            GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 0));

        }
        if (collision.gameObject.name == "gameover"&&overhan==0) 
        {

            score[x.i] -= 100;
            score[x.i] -= 20 - (int)count.countTime;
            overhan = 1;

        

        }
     
    }
 
}
