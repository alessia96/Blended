using UnityEngine;
using System.Collections;

public class anim : MonoBehaviour {
    public GameObject logo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MovieTexture comp = (MovieTexture)logo.GetComponent<Renderer>().material.mainTexture;
        comp.Play();

	}
}
