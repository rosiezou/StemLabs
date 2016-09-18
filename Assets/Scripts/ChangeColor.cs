using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
    public float TotalTimelapse = 5.0f;
    public float Interval = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Interval = Time.deltaTime;
        if (Interval <= 0.0f)
            gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
