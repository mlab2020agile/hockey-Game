using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoalScript : MonoBehaviour
{
    public int color = 0, count;
    public Text countText;

    // Start is called before the first frame update
    public void Start()
    {
        count = 0;
        countText.text = "得点" + count.ToString();

    }
    //OnCollisionEnter()
    public void OnCollisionEnter(Collision collision)
    {
        //色を黒に変化させる
        if (color == 0)
        {
            GetComponent<Renderer>().material.color = Color.black;
            color = 1;

        }
        else if (color == 1) { GetComponent<Renderer>().material.color = Color.red; color = 0; }
        count = count + 1;
        countText.text = "得点" + count.ToString();

        //効果音の出力
        GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    void Update()
    {


    }
}