using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        //色を黒に変化させる
        GetComponent<Renderer>().material.color = Color.black;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
