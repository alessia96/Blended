using UnityEngine;
using System.Collections;
using UnityEditor;

public class LevelManager : MonoBehaviour
{
    private GameObject[] picks = new GameObject[3];
    public GameObject blue;
    public GameObject green;
    public GameObject orange;
    public GameObject red;
    public GameObject violet;
    private GameManager gameManager;
    public GameObject gameManagerHolder;

    void Start()
    {
        gameManager = gameManagerHolder.GetComponent<GameManager>();
    }

    public void AddToPicked(GameObject testTube)
    {
        if (picks[2] == null)
        {
            picks[2] = testTube;
        } else if (picks[1] == null)
        {
            picks[1] = testTube;
        } else if (picks[0] == null)
        {
            picks[0] = testTube;
            CheckCorrectness();
        }
    }

    void CheckCorrectness()
    {
        if (ArrayUtility.Contains(picks, orange) && ArrayUtility.Contains(picks, red) && ArrayUtility.Contains(picks, violet))
        {
            Success();
        }
        else
        {
            Failure();
        }

        picks[0] = null;
        picks[1] = null;
        picks[2] = null;
    }

    void Success()
    {
        //
    }

    void Failure()
    {
        gameManager.DecreaseHealth();
    }
}
