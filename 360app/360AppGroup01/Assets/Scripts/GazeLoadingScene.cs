using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GazeLoadingScene : MonoBehaviour {

    public float myTime = 0f;
    public Transform RadialProgress;
    //public Transform nextSphere;
  

    public float gazeTime = 3f;

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
        
            ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
           
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
