using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    



    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject gameObj = otherCollider.gameObject;

        if(gameObj.GetComponent<Defenders>())
        {
            GetComponent<Attacker>().AttackOn(gameObj);
        }


    }







}//CLASS
