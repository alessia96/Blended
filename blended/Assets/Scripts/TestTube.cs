using UnityEngine;
using System.Collections;

public class TestTube : MonoBehaviour
{
    private bool terminalInUse;
    public GameObject terminal;
    public GameObject currentTestTube;
    private GameObject dummy;
    public GameObject flaskContent;
    private LevelManager levelManager;
    public GameObject levelManagerHolder;

    void Start()
    {
        this.GetComponent<Animator>().enabled = false;
        levelManager = levelManagerHolder.GetComponent<LevelManager>();
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
        this.GetComponent<Animator>().enabled = true;
        levelManager.AddToPicked(currentTestTube);
        flaskContent.GetComponent<Renderer>().materials[0] = currentTestTube.GetComponent<Renderer>().materials[0];
    }

    void PutTestTubeBack()
    {
        dummy.SetActive(true);
        Destroy(currentTestTube);
    }
}
