using UnityEngine;
using System.Collections;

public class TestTube : MonoBehaviour
{
    private bool terminalInUse;
    public GameObject terminal;
    public GameObject currentTestTube;
    private GameObject dummy;
    public GameObject flaskContent;

    void Start()
    {
        this.GetComponent<Animator>().enabled = false;
    }

    void OnMouseDown()
    {
        terminalInUse = terminal.GetComponent<Terminal>().GetActive();

        if (!terminalInUse)
        {
            dummy = Instantiate(currentTestTube);
            dummy.transform.position = currentTestTube.transform.position;
            dummy.SetActive(false);
            UseTestTube();
        }
    }

    void UseTestTube()
    {
        Debug.Log("testtube in use");
        this.GetComponent<Animator>().enabled = true;
        flaskContent.GetComponent<Renderer>().materials[0] = currentTestTube.GetComponent<Renderer>().materials[0];
        Debug.Log(flaskContent.GetComponent<Renderer>().materials[0]);
    }

    void PutTestTubeBack()
    {
        Debug.Log("testtube is back");
        dummy.SetActive(true);
        Destroy(currentTestTube);
    }
}
