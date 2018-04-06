using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GazeTimer : MonoBehaviour
{

    public float Mytime = 0f;
    public Transform RadialProgress;


    void Start()
    {
        RadialProgress.GetComponent<Image>().fillAmount = Mytime;
    }

     public void Update()
    {
        Mytime += Time.deltaTime;
       
        RadialProgress.GetComponent<Image>().fillAmount = Mytime /3;

        if (Mytime >= 3f);   
    }

    public void Resetinator()
    {
        Mytime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = Mytime;
    }   
}
