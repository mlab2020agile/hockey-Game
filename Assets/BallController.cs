using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{//public GameObject RestartButton;
    bool FirstCollision = true;                     //最初のボールの衝突判定
    public GameObject StartButton;
    
    //ボールの初速を与える用
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }


    //衝突判定(最初の衝突のみ)
    public void StartButtun()
    {
        //ボールが衝突したら
        StartButton.SetActive(false);
       // RestartButton.SetActive(true);
        GameObject director = GameObject.Find("GameDirector");  //オブジェクトの取得
            director.GetComponent<GameDirector>().ChangeFlag();     //GameDirectorのChangeFlag();にアクセス
            FirstCollision = false;                                 //最初のボール衝突判定を消す
        Shoot(new Vector3(1000, 0, -1000));
    }

    // Start is called before the first frame update
    void Start()
    {
      // RestartButton.SetActive(false);
        StartButton.SetActive(true);                            //ボールを発射する
    }

    //ReStart
    public void ReStartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
