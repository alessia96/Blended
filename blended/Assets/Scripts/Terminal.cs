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
        OpenTerminal();
        active = false;
    }

    void OpenTerminal()
    {
        terminalWindow.SetActive(true);
    }

    public bool GetActive()
    {
        return active;
    }
}
