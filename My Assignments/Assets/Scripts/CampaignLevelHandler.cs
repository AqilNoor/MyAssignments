using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CampaignLevelHandler : MonoBehaviour
{
   public int levelsUnlocked = 4;

    public GameObject[] levelIconParents;

    private void Awake()
    {
        for(int i = 0; i < levelsUnlocked; i++)
        {
            // Turn of lock which is at 0 child position
            levelIconParents[i].transform.GetChild(0).gameObject.SetActive(false);

            // Turn on number which is at 1 child position
            levelIconParents[i].transform.GetChild(1).gameObject.SetActive(true);

            // Turn on rotating image which is at 2 child position
            levelIconParents[i].transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
