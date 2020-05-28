using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameDirector : MonoBehaviour
{
    
    float time = 60.0f;                 //ゲームは60秒間
    public bool TimerStart = false;     //タイマースタートのフラグ trueでスタート
    GameObject timerText;               //UIのテキスト用
    GameObject front;
    public Text finaler;
    GameObject FinalScore;
    int final;
    LostPoint script;

    public GameObject ContinueButton;
    //外部からのアクセスでTimerStartの値を変える
    //1回目のボールの衝突でTimerStartの値を変える
    public void ChangeFlag()
    {
        TimerStart = true;
    }

    //タイマー
    void timer()
    {
        if (this.time <= 0)
        {
            this.timerText.GetComponent<Text>().text = "終了";
            ContinueButton.SetActive(true);
            FinalScore.SetActive(true);
        }
        else
        {
            this.time -= Time.deltaTime;
            this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        }
    }

    public void ReStartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Start is called before the first frame update
    public void Start()
    {
        front = GameObject.Find("front");
        script = front.GetComponent<LostPoint>();
        int final = script.score;
        finaler.text = "総Score:" + final.ToString();

        this.timerText = GameObject.Find("Time");
        ContinueButton.SetActive(false);
      //  FinalScore.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        
        //
        if (TimerStart)
        {
            //タイマースタート
            timer();
        }
        int final = script.score;
        finaler.text = "総Score:" + final.ToString();
    }


}
