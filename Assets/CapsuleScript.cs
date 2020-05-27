using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    public float capsuleX = 0.3f;                       //オブジェクトの速度
    private Vector3 position;                           //オブジェクトの位置用変数


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        position = gameObject.transform.position;       //オブジェクトの位置情報を取得

        //動作範囲の条件文
        if (position.x < -13 || position.x > 13)
        {
            capsuleX = -1 * capsuleX;   //速度を反転させる
        }

        this.gameObject.transform.Translate(capsuleX,0,0);//オブジェクトを動かす
    }
}
