using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
    public bool text;
    private bool logoAnim = false;
    public GameObject curtainClose;
    public GameObject curtainOpen;
    public GameObject texto;
    public GameObject logo;
    // Use this for initialization
    void Start () {
        curtainOpen.SetActive(true);
        text = false;
	}
	
	// Update is called once per frame
	void Update () {
        //get the key pressed
        if (Input.GetKeyDown(KeyCode.Space) && !text) {
            StartCoroutine(resetCurtainOpen());
            curtainClose.SetActive(true);
            logo.SetActive(false);
            StartCoroutine(resetCurtainClose());
            StartCoroutine(waitText());
        }
        if (text) {
            texto.SetActive(true);
            if (texto.GetComponent<typewriter>().complete) {
                if (Input.GetKeyDown(KeyCode.Space)) {
                    curtainClose.SetActive(true);
                    StartCoroutine(loadScene());
                }
            }

        }
   
	}

    IEnumerator loadScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }

    IEnumerator resetCurtainOpen() {
        yield return new WaitForSeconds(3f);
        curtainOpen.SetActive(false);
    }
    IEnumerator resetCurtainClose() {
        yield return new WaitForSeconds(3f);
        curtainClose.SetActive(false);
    }
    IEnumerator waitText() {
        yield return new WaitForSeconds(2f);
        text = true;
    }
}
