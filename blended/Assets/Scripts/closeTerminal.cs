using UnityEngine;
using System.Collections;

public class closeTerminal : MonoBehaviour {

    public GameObject window;

    void OnMouseDown() {
        shutDown();
    }

    void shutDown() {
        window.SetActive(false);
    }
}
