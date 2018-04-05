using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class sphereInteractive : MonoBehaviour {

    public Text timeText;
    public Slider sliderBar;
    private Image fillImg;
    float timeAmt = 10;
    private float time;


    public float gazeTime = 2f;

    public GameObject guiObject;
    public int levelToLoad;
    public GameObject canvaS;

    private float timer;
    private bool gazeDat;



    // Use this for initialization
    void Start () {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
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
