using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
    public float TotalTimelapse = 5.0f;
    public float Interval = 1.0f;
    public float red = 0.3f;
    public float green = 2.0f;
    public float blue = 1.0f;
    public float transparency = 0.0f;
	// Use this for initialization
	void Start () {
        Renderer rend = GetComponent<Renderer>();
        //rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
        Update();
	}
	
	// Update is called once per frame
	void Update () {
        red = Time.deltaTime * 20f;
        green = Time.deltaTime * 30f;
        blue = Time.deltaTime * 50f;
        transparency = Time.deltaTime * 10f;
        gameObject.GetComponent<Renderer>().material.color = new Vector4(red, green, blue, transparency);
        }
    }