using UnityEngine;
using System.Collections;

public class ChangeColor2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Update();
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(fadeColor(gameObject, Color.red, 10));
    }
    IEnumerator fadeColor(GameObject objectToFade, Color newColor, float fadeTime = 3)
    {
        int mode = 0;

        Color currentColor = Color.clear;

        SpriteRenderer tempSPRenderer = objectToFade.GetComponent<SpriteRenderer>();
        UnityEngine.UI.Image tempImage = objectToFade.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.UI.RawImage tempRawImage = objectToFade.GetComponent<UnityEngine.UI.RawImage>();
        Renderer tempRenderer = objectToFade.GetComponent<Renderer>();

        //Check if this is a Sprite
        if (tempSPRenderer != null)
        {
            currentColor = tempSPRenderer.color;
            mode = 0;
        }
        //Check if Image
        else if (tempImage != null)
        {
            currentColor = tempImage.color;
            mode = 1;
        }
        //Check if RawImage
        else if (tempRawImage != null)
        {
            currentColor = tempRawImage.color;
            mode = 2;
        }
        //Check if 3D Object
        else if (tempRenderer != null)
        {
            currentColor = tempRenderer.material.color;
            mode = 3;
        }
        else
        {
            yield break;
        }

        float counter = 0;

        while (counter < fadeTime)
        {
            counter += Time.deltaTime;
            switch (mode)
            {
                case 0:
                    tempSPRenderer.color = Color.Lerp(currentColor, newColor, counter / fadeTime);
                    break;
                case 1:
                    tempImage.color = Color.Lerp(currentColor, newColor, counter / fadeTime);
                    break;
                case 2:
                    tempRawImage.color = Color.Lerp(currentColor, newColor, counter / fadeTime);
                    break;
                case 3:
                    tempRenderer.material.color = Color.Lerp(currentColor, newColor, counter / fadeTime);
                    break;
            }
            yield return null;
        }
    }

}
