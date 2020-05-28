using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RacketScript : MonoBehaviour
{
    // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    // Use this for initialization

    private Vector3 pos;
    private Vector3 posz;

    // マウスホイールの回転値を格納する変数
    private float scroll;
    // ラケット移動の速度
    public float speed = 1000f;

    //効果音の出力
    void OnCollisionEnter(Collision collision){
        GetComponent<AudioSource>().Play();
    }

    void Start()
    {
        posz.z = -10f;
    }

    // Update is called once per frame
    void Update()
    {
        // マウスホイールの回転値を変数 scroll に渡す
        scroll = 0;
        scroll = Input.GetAxis("Mouse ScrollWheel");

        if(scroll != 0){
            if(posz.z < -14.23f){
                posz.z = -14.23f;
            }else if(posz.z > 14.23f){
                posz.z = 14.23f;
            }else{
                posz.z += scroll * 10f;
            }
        }

        // Vector3でマウス位置座標を取得する
        position = Input.mousePosition;
        // Z軸修正
        position.z = 21.54f;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        // ワールド座標に変換されたマウス座標を代入
        gameObject.transform.position = screenToWorldPointPosition;
        //gameObject.transform.positionの座標をいじるための変数pos
        pos = gameObject.transform.position;
        //posのz軸をマウスホイールで設定
        //this.gameObject.transform.Translate (position.x, position.y, scroll * speed);
        

        //壁よりもラケットが外に行かないようにする為の条件文
        if (pos.y > 17.2f)
        {
            pos.y = 17.2f;
        }
        if (pos.y < 2.9f)
        {
            pos.y = 2.9f;
        }
        if (pos.x > 12.2f)
        {
            pos.x = 12.2f;
        }
        if (pos.x < -12.2f)
        {
            pos.x = -12.2f;
        }

        pos.z = posz.z;
        gameObject.transform.position = pos;  // 座標を設定
        Debug.Log(scroll); //デバック
    }
}