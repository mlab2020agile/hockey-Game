using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
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

        transform.Rotate(new Vector3(0, 5, 0)); //回転させる
    }
}
