using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private int health = 3;
    private int kills = 0;
    public GameObject fallOffChair;
    public GameObject mainCamera;

    void Update()
    {
        if (health == 0)
        {
            FallOffChair();
        }
        else if (kills == 3)
        {
            KillByGuards();
        }
    }

    void FallOffChair()
    {
        mainCamera.SetActive(false);
        fallOffChair.SetActive(true);
    }

    void KillByGuards()
    {

    }
}
