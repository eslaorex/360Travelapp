using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitButton : MonoBehaviour {

    public float gazeTime = 2f;
    private float timer;
    private bool gazeDat;



    void Update()
    {
        if (gazeDat)
            timer += Time.deltaTime;

        if (timer >= gazeTime)
        {
            //PointerDown();
            Application.Quit();
            ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
        }
    }

    public void PointerEnter()
    {
        gazeDat = true;
    }

    public void PointerExit()
    {
        gazeDat = false;     
    }

    public void PointerDown()
    {
        gazeDat = true;
        Application.Quit();
    }


}
