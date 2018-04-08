using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereChangerNoFade : MonoBehaviour {

    //This ensures that we don't mash to change spheres
    //bool changing = false;


    public void ChangeSphere(Transform nextSphere)
    {
        Camera.main.transform.parent.position = nextSphere.position;
        //Start the fading process

    }

    

}
