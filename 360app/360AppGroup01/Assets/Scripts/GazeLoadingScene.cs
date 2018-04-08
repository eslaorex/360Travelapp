using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GazeLoadingScene : MonoBehaviour {

    public float myTime = 0f;
    public Transform RadialProgress;
    //public Transform nextSphere;
    private bool gazeDat;

    public float gazeTime = 3f;
    void Start () {
        RadialProgress.GetComponent<Image>().fillAmount = myTime;
    }
		
	public void Update ()
    {
        if (gazeDat)
            myTime += Time.deltaTime;
            RadialProgress.GetComponent<Image>().fillAmount = myTime / 3;

        if (myTime >= 3f)
        {
           ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
           
           PointerDown();          
        }
    }
    
    public void PointerEnter()
    {
        gazeDat = true;
    }

    public void PointerExit()
    {
        gazeDat = false;
        myTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = myTime / 3;
    }

    public void PointerDown()
    {
        Debug.Log("CHANGE SPHERE");
    
    }

}
