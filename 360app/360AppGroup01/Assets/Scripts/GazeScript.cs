﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GazeScript : MonoBehaviour {

    public float gazeTime = 2f;
    //private float timer;
    private bool gazeDat;

    public float Mytime = 0f;
    public Transform RadialProgress;

    // Use this for initialization
    void Start () {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 20, 0));
        
        if (gazeDat)
            Mytime += Time.deltaTime;
            RadialProgress.GetComponent<Image>().fillAmount = Mytime / 3;
        

        if (Mytime >= gazeTime)
        {
            //PointerDown();
            
            ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
            
        }
        
    }

    public void PointerEnter()
    {
        gazeDat = true;
        Debug.Log("Pointer Enter");
        
    }

    public void PointerExit()
    {
        gazeDat = false;
        Debug.Log("Pointer Exit");
       
    }

    public void PointerDown()
    {
        gazeDat = true;
        Debug.Log("Pointer Down");
        
    }

    public void Resetinator()
    {
        Mytime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = Mytime / 3;
    }



}
