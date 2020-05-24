using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour
{
    
    float time = 60.0f;                 //ゲームは60秒間
    public bool TimerStart = false;     //タイマースタートのフラグ trueでスタート
    GameObject timerText;               //UIのテキスト用

    //外部からのアクセスでTimerStartの値を変える
    //1回目のボールの衝突でTimerStartの値を変える
    public void ChangeFlag()
    {
        TimerStart = true;
    }

    //タイマー
    void timer()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
    }


    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
    }

    // Update is called once per frame
    public void Update()
    {
        //
        if(TimerStart)
        {
            //タイマースタート
            timer();
        }
    }
}
