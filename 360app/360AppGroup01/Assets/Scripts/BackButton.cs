using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

    public float gazeTime = 2f;

    public GameObject guiObject;
    public int levelToLoad;
    public GameObject canvaS;

    private float timer;
    private bool gazeDat;

    GameObject m_Fader;

    // Use this for initialization
    void Awake()
    {
        m_Fader = GameObject.Find("Fader");

        //Check if we found something
        if (m_Fader == null)
            Debug.LogWarning("No Fader object found on camera.");
    }

    // Update is called once per frame
    void Update()
    {
        

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
        Debug.Log("Pointer Enter");
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
