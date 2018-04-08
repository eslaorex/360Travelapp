using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

    public float gazeTime = 3f;


    public int levelToLoad;
    
    private float timer;
    private bool gazeDat;

  


    void Update()
    {
        

        if (gazeDat)
            timer += Time.deltaTime;

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
