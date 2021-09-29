using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour
{
    [SerializeField] float starCost = 50f;
    

    public float GetStarCost()
    {
        return starCost;
    }

    public void TrophyStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }

}//CLASS
