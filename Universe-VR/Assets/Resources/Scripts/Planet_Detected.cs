using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Detected : MonoBehaviour {

    public Material lit;
    public Material unlit;
	
    // Use this for initialization
	void Start () {

        GetComponent<Renderer>().material = lit;

    }

	
    public void WatchingYou()
    {
        GetComponent<Renderer>().material = unlit;
    }

    public void NotWatchingYou()
    {
        GetComponent<Renderer>().material = lit;

    }
}
