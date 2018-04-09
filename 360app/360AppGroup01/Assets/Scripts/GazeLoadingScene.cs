﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GazeLoadingScene : MonoBehaviour {

    public float myTime = 0f;
    public Transform RadialProgress;
    public float gazeTime = 3f;
    public Transform nextSphere;


    void Start ()
    {
        //RadialProgress.GetComponent<Image>().fillAmount = myTime / 3;
    }
		
	public void Update ()
    {
          
        
            myTime += Time.deltaTime;
            RadialProgress.GetComponent<Image>().fillAmount = myTime / 3;
        
            

        if (myTime >= gazeTime)
        {
            //ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
            Camera.main.transform.parent.position = nextSphere.position;



        }
    }
    



    public void PointerEnter()
    {
     
    }

    public void PointerExit()
    {
     
        myTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = myTime / 3;
    }

    public void PointerDown()
    {
   
    
    }

 


}
