using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LevelManager : MonoBehaviour
{
    private ArrayList picks = new ArrayList();
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
        picks.Add(testTube);
        if (picks.Count == 3)
        {
            CheckCorrectness();
        }
    }

    void CheckCorrectness()
    {
        if (picks.Contains(orange) && picks.Contains(red) && picks.Contains(violet))
        {
            Success();
        }
        else
        {
            Failure();
        }

        picks.RemoveRange(0,3);
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
