using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class video : MonoBehaviour {

    public MovieTexture texture;
    

    // Use this for initialization
	void Start () {
        GetComponent<RawImage>().texture = texture as MovieTexture;
	}
	
	// Update is called once per frame
	void Update () {
        playMovie();
	}

    void playMovie() {
        texture.Play();
    }
}
