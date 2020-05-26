using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class IgaguriController : MonoBehaviour
{
  //  public GameObject StartButton;
  //  public GameObject ReStartButton;
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    public void OnCollisionEnter(Collision Enter)
    {
        //GetComponent<Rigidbody>().isKinematic = true;
    }

    // Start is called before the first frame update
    public void Start()
    {
        //ReStartButton.SetActive(false);
      //  StartButton.SetActive(true);
     //  Shoot(new Vector3(1000, 0, 1000));
    }

    //Start
    public void StartButton()
    {
      
        //  StartButton.SetActivie(false);
        Shoot(new Vector3(1000, 0, 1000));
        // ReStartButton.SetActive(true);
    }

    //ReStart
    public void ReStartButton()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
