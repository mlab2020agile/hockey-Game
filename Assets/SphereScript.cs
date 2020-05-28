using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public float sphereY = 0.3f;                        //オブジェクトの速度
    private Vector3 position;                           //オブジェクトの位置用変数

    //効果音の出力
    void OnCollisionEnter(Collision collision){
        GetComponent<AudioSource>().Play();
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        position = gameObject.transform.position;       //オブジェクトの位置情報を取得
        
        //動作範囲の条件文
        if (position.y < 3 || position.y > 17)          
        {
            sphereY = -1 * sphereY; //速度を反転させる
        }

        this.gameObject.transform.Translate(0, sphereY, 0); //オブジェクトを動かす
    }
}
