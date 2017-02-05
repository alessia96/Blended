using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    private GameObject[] picks;

    void Start()
    {
        picks = new GameObject[3];
    }

    void AddToPicked(GameObject testTube)
    {
        if (picks[0] == null)
        {
            picks[0] = testTube;
        } else if (picks[1] == null)
        {
            picks[1] = testTube;
        } else if (picks[2] == null)
        {
            picks[2] = testTube;
        }
    }
	
}
