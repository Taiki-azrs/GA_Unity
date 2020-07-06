using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;



public class ita : MonoBehaviour
{
    public float left = 0;
    public float right = 0;
    public float up = 0;
    public float down = 0;
    public static int kotai = 0;
    public int i;
    public int j = 0;
    public static int[,] con = new int[8, 1500];
    public int ran;
    public int test;
    public int zaz;
    public int v = 0;
    public float nia=0;

    Vector3 q;
    // Use this for initialization

    void Start()
    {
        if (time.gen == 0)
        {
            for (i = 0; i <= 7; i++)
            {
                for (j = 0; j <= 1499; j++)
                {
                    con[i, j] = 6;
                }
            }
        }
        j = 0;
        switch (kotai)
        {
            case 0: kotai = 1; i = 0; break;
            case 1: kotai = 2; i = 1; break;
            case 2: kotai = 3; i = 2; break;
            case 3: kotai = 4; i = 3; break;
            case 4: kotai = 5; i = 4; break;
            case 5: kotai = 6; i = 5; break;
            case 6: kotai = 7; i = 6; break;
            case 7:
                i = 7; break;


        }



    }
    // Update is called once per frame
    void FixedUpdate()
    {


 
            if (time.gen == 0)
            {

                randam(j);
                j++;

            }
            else
            {
                if (con[i, v] == 9)
                {
                    randam(v);
                    v++;
                }
                else
                {

                    sousa(con[i, v]);
                    v += 1;
                    zaz = con[i, v];
                }


 
        }
    }
    void randam(int k)
    {
        ran = UnityEngine.Random.Range(0, 6);
        sousa(ran);
        con[i, k] = ran;
        test = con[i, k];


    }


    void sousa(int x)
    {
            switch (x)
        {

            case 0:
                transform.Rotate(2f, 0, 0);
                break;
            case 1:

                transform.Rotate(-2f, 0, 0);
                break;
            case 2:

                transform.Rotate(0, 0, 2f);
                break;
            case 3:

                transform.Rotate(0, 2f, 0);
                break;
            case 4:
                transform.Rotate(0, -2f, 0);
                break;
            case 5:
                transform.Rotate(0, 0, -2f);
                break;

        }

    }
}

