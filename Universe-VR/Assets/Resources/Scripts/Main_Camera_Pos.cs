using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Camera_Pos : MonoBehaviour {

    // Use this for initialization
    public GameObject Sun;
    private Vector3 offset;

	void Start () {
        offset = transform.position - Sun.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = Sun.transform.position + offset;
        
    }
}
