using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PraktikumController : MonoBehaviour
{
    public GameObject[] GO;
    public int PCount;

    public void next()
    {
        if (PCount < GO.Length-1)
        {
            PCount += 1;
            for (int i = 0; i < GO.Length; i++)
            {
                GO[i].SetActive(false);
            }
            GO[PCount].SetActive(true);
        }
        
    }

    public void prev()
    {
        if (PCount >= 1)
        {
            PCount -= 1;
            for (int i = 0; i < GO.Length; i++)
            {
                GO[i].SetActive(false);
            }
            GO[PCount].SetActive(true);
        }
    }
}
