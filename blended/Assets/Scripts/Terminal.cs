using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour
{
    private bool active;

    void Start()
    {
        active = true;
	}
	
	void OnMouseDown()
    {
        if (active)
        {
            OpenTerminal();
            active = false;
        }
    }

    void OpenTerminal()
    {
        //govind's stuff
        Debug.Log("opened terminal");
    }
}
