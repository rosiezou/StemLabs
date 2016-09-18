using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
    public float TotalTimelapse = 10.0f;
    public float Interval = 1.0f;
    public float initRed = 0.0f;
    public float initGreen = 0.0f;
    public float initBlue = 1.0f;

    public float red = 0.0f;
    public float green = 0.0f;
    public float blue = 0.0f;

    public float transparency = 1.0f;
    public float finalRed = 1.0f;
    public float finalBlue = 0.0f;
    public float finalGreen = 1.0f;
    public float totalTime = 0.0f;
	// Use this for initialization
	void Start () {
        //need a trigger

        Renderer rend = GetComponent<Renderer>();
        //rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
        Update();
	}
	
	// Update is called once per frame
	void Update () {
        if (totalTime > 5.0f) return;
        float t = Time.deltaTime;
        Debug.Log(t);
        totalTime += t;
        Debug.Log(totalTime);
        red = ((1.0f - (totalTime / TotalTimelapse)) * initRed) + ((totalTime / TotalTimelapse) * finalRed);
        green = ((1.0f - (totalTime / TotalTimelapse)) * initGreen) + ((totalTime / TotalTimelapse) * finalGreen);
        blue = ((1.0f - (totalTime / TotalTimelapse)) * initBlue) + ((totalTime / TotalTimelapse) * finalBlue);
        transparency = 1.0f;
        Debug.Log(red);
        Debug.Log(green);
        Debug.Log(blue);
        Debug.Log(transparency);
        gameObject.GetComponent<Renderer>().material.color = new Vector4(red, green, blue, transparency);
        }
    }