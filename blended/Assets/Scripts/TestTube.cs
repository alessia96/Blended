using UnityEngine;
using System.Collections;

public class TestTube : MonoBehaviour
{
    private bool terminalInUse;
    public GameObject terminal;
    private Vector3 testTubeLocation; //saving location before animation

    void OnMouseDown()
    {
        terminalInUse = terminal.GetComponent<Terminal>().GetActive();

        if (!terminalInUse)
        {
            UseTestTube();
        }
    }

    void UseTestTube()
    {
        Debug.Log("testtube in use");
        testTubeLocation = this.GetComponent<Transform>().position;
        this.GetComponent<Animator>().enabled = true;
    }

    void PutTestTubeBack()
    {
        Debug.Log("testtube is back");
        this.GetComponent<Animator>().enabled = false;
        this.GetComponent<Animation>().enabled = false;
        this.transform.Translate(testTubeLocation);
    }
}
