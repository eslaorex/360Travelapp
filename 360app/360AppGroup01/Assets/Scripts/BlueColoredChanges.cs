using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueColoredChanges: MonoBehaviour {

    public Material noLooky;
    public Material eyeSpy;

    void Start () {
        GetComponent<Renderer>().material = noLooky;
	}
	
	public void TotallyWatching()
    {
        GetComponent<Renderer>().material = eyeSpy;
    }

    public void NotEvenLooking()
    {
        GetComponent<Renderer>().material = noLooky;
    }
}
