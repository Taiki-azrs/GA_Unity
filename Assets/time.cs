using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public float countTime = 0;
    public static int gen = 0;
    public static int one = -500;
    public static int two = -500;
    public static int it = 0;
    public static int ni = 0;
    public static float tm=0.0f;
    public static int f=-500;
    public static int xc = 0;
    
    // Use this for initialization
    void Start()
    {

        GameObject.Find("genbest").GetComponent<Text>().text = f.ToString();
        GameObject.Find("message").GetComponent<Text>().text = one.ToString();
        GameObject.Find("gen").GetComponent<Text>().text = gen.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime; //スタートしてからの秒数を格納
        GameObject.Find("Text").GetComponent<Text>().text = countTime.ToString("F2"); //小数2桁にして表示
        if (countTime >= 20.00)
        {
            tm = countTime;
        
            ita.kotai = 0;
            gen += 1;
            hyouka();
            kousa();
            SceneManager.LoadScene("ga3");
        }
    }
    void hyouka()
    {
        f = -1000;
        two = -500;
        one = -500;
        for (int g = 0; g <= 7; g++)
        {
            if (atari.score[g] > one) { two = one;ni = it; one = atari.score[g];it = g; }
            else if (atari.score[g] > two&&it!=g) { two = atari.score[g]; ni = g; }
        }
        for (int m = 0; m <= 7; m++)
        {
            if (atari.score[m] > f)
            {
                f = atari.score[m];

            }
            atari.score[m] = 0;
        }
        GameObject.Find("message").GetComponent<Text>().text = one.ToString();
        Debug.Log(it);
    }
    void kousa()
    {

        for (int g = 0; g <= 7; g++)
        {
            int ot = Random.Range(1, 3);
            int kisi = Random.Range(0, 801);
            int tree = kisi + 300;
            if (g != it)
            {
                if (g != ni)
                {
                    Debug.Log(g);
                    for (int c = 0; c <= 1499; c++)
                    {
                        if (kisi == c)
                        {

                            while (c <= tree)
                            {
                                if (Random.Range(0, 10) == 0)
                                {
                                    ita.con[g, c] = Random.Range(0, 6);
                                }
                                else
                                {
                                    switch (ot)
                                    {
                                        case 1: ita.con[g, c] = ita.con[ni, c]; break;
                                        case 2: ita.con[g, c] = ita.con[it, c]; break;
                                    }
                                }
                                c++;
                            }
                        }
                        else
                        {
                            if (Random.Range(0, 10) == 0)
                            {
                                ita.con[g, c] = Random.Range(0, 6);
                            }
                            else
                            {
                                switch (ot)
                                {
                                    case 1: ita.con[g, c] = ita.con[it, c]; break;
                                    case 2: ita.con[g, c] = ita.con[ni, c]; break;
                                }
                            }
                        }


                    }
                }
            }
        }
    }
}