using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour {

    public float gazeTime = 3f;


    private float timer = 0f;

    public Transform RadialProgress;


    void Update()
    {



        timer += Time.deltaTime;
        RadialProgress.GetComponent<Image>().fillAmount = timer / 3;

        if (timer >= 3f)
        {

            Application.Quit();
        }
    }

    public void PointerEnter()
    {

        Debug.Log("Pointer Enter");

    }

    public void PointerExit()
    {
        timer = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = timer / 3;

    }

    public void PointerDown()
    {


    }

}
