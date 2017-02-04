using UnityEngine;
using System.Collections;

public class closeTerminal : MonoBehaviour {

    public GameObject window;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        shutDown();
    }

    void shutDown() {
        window.SetActive(false);
    }
}
