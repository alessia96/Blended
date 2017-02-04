using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour
{
    private bool active;
    public GameObject terminalWindow;
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
        terminalWindow.SetActive(true);
        Debug.Log("opened terminal");
    }

    public bool GetActive()
    {
        return active;
    }
}
