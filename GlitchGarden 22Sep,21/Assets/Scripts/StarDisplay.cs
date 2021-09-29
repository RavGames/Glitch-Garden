using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StarDisplay : MonoBehaviour
{
    [SerializeField] float stars = 100f;

    private Text starText;

    private void Start()
    {
        starText = GetComponent<Text>();
        DisplayUpdate();
    }

    private void DisplayUpdate()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(float amount)
    {
        stars += amount;
        DisplayUpdate();
    }

    public void SpendStars(float amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            DisplayUpdate();
        }
    }

    public bool hasStars(float amount)
    {
        return stars >= amount;
    }

}//CLASS
