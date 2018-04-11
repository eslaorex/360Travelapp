using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BackButton : MonoBehaviour {

    public float gazeTime = 2f;

    public int levelToLoad;
    
    private float timer = 0f;

    public Transform RadialProgress;


    void Update()
    {
        

     
            timer += Time.deltaTime;
            RadialProgress.GetComponent<Image>().fillAmount = timer / 2;

        if (timer >= 2f)
        {
            
            SceneManager.LoadScene(levelToLoad);
        }
    }

    public void PointerEnter()
    {
   
        Debug.Log("Pointer Enter");
       
    }

    public void PointerExit()
    {
        timer = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = timer / 2;

    }

    public void PointerDown()
    {
        
       
    }

}
