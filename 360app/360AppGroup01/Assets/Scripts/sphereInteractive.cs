using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sphereInteractive : MonoBehaviour {

    public float gazeTime = 3f;
    public GameObject canvaS; 
    public int levelToLoad;
    public Transform RadialProgress;

    private float timer;



   


    void Update () {

        transform.Rotate(new Vector3(0, Time.deltaTime * 20, 0));


        timer += Time.deltaTime;
             RadialProgress.GetComponent<Image>().fillAmount = timer / 3;
        if (timer >= gazeTime)
        {
            
            ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
        }

    }

    public void PointerEnter()
    {
        
        canvaS.SetActive(true);
    }

    public void PointerExit()
    {
       canvaS.SetActive(false);
        timer = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = timer / 3;

        
    }

    public void Rotate()
    {
        
    }
    public void PointerDown()
    {
        
        
        SceneManager.LoadScene(levelToLoad);
        canvaS.SetActive(false);
    }



}
