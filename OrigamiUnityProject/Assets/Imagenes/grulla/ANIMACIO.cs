using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ANIMACIO : MonoBehaviour {

    public Sprite[] frames;
    public float framesPorSegundo = 10; 
    void Update()
    {
        float index = Time.time * framesPorSegundo;
        index = index % frames.Length;
        GetComponent<Image>().sprite = frames[(int)index];
    }

    // Use this for initialization
    void Start () {
		
	}
	
}
