using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
    private bool text;
    private bool logoAnim = false;
    GameObject curtainClose = GameObject.Find("CurtainClose");
    GameObject curtainOpen = GameObject.Find("CurtainOpen");

    // Use this for initialization
    void Start () {
        curtainOpen.SetActive(true);
        text = false;
	}
	
	// Update is called once per frame
	void Update () {
        //get the key pressed
        if (Input.GetKeyDown(KeyCode.Space)) {
            logoAnim = true;
            //play the animation
            if (logoAnim) {
                //play logo animation and check for its finish using isPlaying()
                //set curtainOpen to inactive and activate curtain close
                if (!isPlaying()) {
                    curtainClose.SetActive(true);
                    curtainOpen.SetActive(false);
                }
            }
            text = true;
        }
        if (text) {
            //scroll text animation

        }
   
	}
    bool isPlaying(){
        return true;
    }
}
