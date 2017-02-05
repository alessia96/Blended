using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour
{
    private bool active;
    public GameObject terminalWindow;
    private Animator exclamation;
    public GameObject terminal;

    void Start()
    {
        active = true;
        exclamation = terminal.GetComponent<Animator>();
	}
	
	void OnMouseDown()
    {
        OpenTerminal();
        active = false;
    }

    void OpenTerminal()
    {
        terminalWindow.SetActive(true);
        exclamation.enabled = false;
    }

    public bool GetActive()
    {
        return active;
    }
}
