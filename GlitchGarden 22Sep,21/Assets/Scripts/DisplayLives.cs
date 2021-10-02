using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DisplayLives : MonoBehaviour
{
    
    [SerializeField] float totalLives = 3f;
    //[SerializeField] float damage = 1f;

    private Text livesText;


    private void Start()
    {
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
