using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    bool FirstCollision = true;                     //最初のボールの衝突判定

    //ボールの初速を与える用
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }


    //衝突判定(最初の衝突のみ)
    public void OnCollisionEnter(Collision Enter)
    {
        //ボールが衝突したら
        if (FirstCollision)
        {
            GameObject director = GameObject.Find("GameDirector");  //オブジェクトの取得
            director.GetComponent<GameDirector>().ChangeFlag();     //GameDirectorのChangeFlag();にアクセス
            FirstCollision = false;                                 //最初のボール衝突判定を消す
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Shoot(new Vector3(0, 0, -1000));                            //ボールを発射する
    }

}
