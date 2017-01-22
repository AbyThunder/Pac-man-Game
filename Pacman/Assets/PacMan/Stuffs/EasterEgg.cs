using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour {

    Material mat;
    Renderer rend;

    float time = 0f;

    public Gradient colorGrad;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        mat = rend.material;
    }
	
	// Update is called once per frame
	void Update () {

        mat.shader = Shader.Find("Standard");
        mat.SetColor("_Color", colorGrad.Evaluate(time));
        if (time >= 1f)
        {
            time = 0f;
        }
        else {
            time += 0.01f;
        }
	}
}
