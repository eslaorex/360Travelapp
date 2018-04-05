using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class sphereInteractive : MonoBehaviour {

    public float gazeTime = 2f;
    public GameObject canvaS; 
    public int levelToLoad;
    

    private float timer;
    private bool gazeDat;


    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3(0, Time.deltaTime * 20, 0));

        if (gazeDat)
            timer += Time.deltaTime;

        if (timer >= gazeTime)
        {
            //PointerDown();
            ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
        }

    }

    public void PointerEnter()
    {
        gazeDat = true;
        canvaS.SetActive(true);
    }

    public void PointerExit()
    {
        gazeDat = false;
        Debug.Log("Pointer Exit");
        canvaS.SetActive(false);
    }

    public void PointerDown()
    {
        gazeDat = true;
        Debug.Log("Pointer Down");
        SceneManager.LoadScene(levelToLoad);
        canvaS.SetActive(false);
    }



}
