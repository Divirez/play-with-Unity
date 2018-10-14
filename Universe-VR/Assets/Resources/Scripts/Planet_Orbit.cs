using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Orbit : MonoBehaviour {

    private float timecounter;
    private float x;
    private float z;
    public float speed;
    public float width;
    public float depth;

    // Use this for initialization
    void Start()
    {
        timecounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime * speed / 5;

        x = Mathf.Cos(timecounter) * width;
        z = Mathf.Sin(timecounter) * depth;

        transform.position = new Vector3(x, 0.0f, z);

        transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100, 0.0f));
    }
}
