using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LostPoint : MonoBehaviour
{
    GameObject back;
    public int  count,score;
    GoalScript script;
    
    public Text countText;
    // Start is called before the first frame update
   public void Start()
    {   back = GameObject.Find("back");
        script = back.GetComponent<GoalScript>();
        int getpoint = script.count;
       // Debug.Log(getpoint);
        count = 0;
        score = getpoint - count;
        countText.text = "失点" + count.ToString()+"\nScore" + score.ToString();
    }
    void OnCollisionEnter(Collision collision)
    {
       count = count + 1;
       
        //効果音の出力
        GetComponent<AudioSource>().Play();
    
    }
    // Update is called once per frame
   public void Update()
    { int getpoint = script.count;
        score = getpoint - count;
        countText.text = "失点" + count.ToString()+"\nScore" + score.ToString();
    }

}
