using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DisplayLives : MonoBehaviour
{
    [SerializeField] float baseLifes = 5f;
    [SerializeField] float totalLives;
    //[SerializeField] float damage = 1f;

    private Text livesText;

    

    private void Start()
    {

        totalLives = baseLifes - PPC.GetMasterDifficulty();
        livesText = GetComponent<Text>();
        UpdateLives();
    }


    private void UpdateLives()
    {
        livesText.text = totalLives.ToString();

    }

    public void LivesLost(float damage)
    {
        totalLives -= damage;

        if(totalLives <= 0)
        {
            UpdateLives();
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }

    public float GetTotalLives()
    {
        return totalLives;
    }

}//CLASS
