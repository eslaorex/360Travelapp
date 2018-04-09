using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BackButton : MonoBehaviour {

    public float gazeTime = 3f;


    public int levelToLoad;
    
    private float timer = 0f;
    private bool gazeDat;


    public Transform RadialProgress;


    void Update()
    {
        

        if (gazeDat)
            timer += Time.deltaTime;
            RadialProgress.GetComponent<Image>().fillAmount = timer / 3;

        if (timer >= gazeTime)
        {
            
            SceneManager.LoadScene(levelToLoad);
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
        
       
    }

}
