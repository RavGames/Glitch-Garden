using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] float noOfAttackers;
    // private AttackerSpawner attackerSpawner;
    [SerializeField] bool levelTimerEnd = false;

    [SerializeField] GameObject winCanvas,loseCanvas;
    

    private void Start()
    {
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);
    }



    public void AttackersSpawned()
    {
        noOfAttackers++;
    }


    //public void AttackersKilled()
    //{
    //    noOfAttackers--;

    //    if(noOfAttackers <= 0 && levelTimerEnd)
    //    {
    //        StopSpawningAttackers();
    //    }

    //}
    //there's another method much perfect than this
    public void AttackersKilled()
    {
        noOfAttackers--;

        if (levelTimerEnd)
        {
            StopSpawningAttackers();
        }

    }


    public void HandleWinCondition()
    {
        if(noOfAttackers <= 0 && levelTimerEnd && FindObjectOfType<DisplayLives>().GetTotalLives() > 0)
        {
            winCanvas.SetActive(true);
            FindObjectOfType<LEvelLoader>().LoadNextLevel();
        }
    }

    public void HandleLoseCondition()
    {
        //FindObjectOfType<Attacker>().DestroyAll();
        loseCanvas.SetActive(true);
        Time.timeScale = 0;
    }


    public void LevelTimerEnd()
    {
        levelTimerEnd = true;
    }

    private void StopSpawningAttackers()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner attackerSpawner in attackerSpawners)
        {
            attackerSpawner.StopSpawning();
        }
    }



}//CLASS
