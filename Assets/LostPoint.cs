using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LostPoint : MonoBehaviour
{
    GameObject back;
    int  count,score;
    GoalScript script;
    
    public Text countText;
    // Start is called before the first frame update
    void Start()
    {   back = GameObject.Find("back");
        script = back.GetComponent<GoalScript>();
        int getpoint = script.count;
       // Debug.Log(getpoint);
        count = 0;
        score = getpoint - count;
        countText.text = "失点" + count.ToString()+"Score" + score.ToString();
    }
    void OnCollisionEnter(Collision collision)
    {
       
        count = count + 1;
        
    }
    // Update is called once per frame
    void Update()
    { int getpoint = script.count;
        score = getpoint - count;
        countText.text = "失点" + count.ToString()+"Score" + score.ToString();
    }

}
