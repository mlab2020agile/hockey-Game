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

    private Vector3 tmp;
    
    void Start()
    {
        tmp = GameObject.Find("racket").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3でマウス位置座標を取得する
        position = Input.mousePosition;
        // Z軸修正
        position.z = 21.54f;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        // ワールド座標に変換されたマウス座標を代入
        gameObject.transform.position = screenToWorldPointPosition;
        //gameObject.transform.positionの座標をいじるための変数pos
        Vector3 pos = gameObject.transform.position;
        //posのz軸を固定
        pos.z = -10f;


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

        gameObject.transform.position = pos;  // 座標を設定
        Debug.Log(pos); //デバック
    }
}