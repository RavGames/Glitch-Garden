using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject gameObj = otherCollider.gameObject;

        if(gameObj.GetComponent<GraveStone>())
        {
            GetComponent<Animator>().SetTrigger("Jump");
        }

        else if (gameObj.GetComponent<Defenders>())
        {
            GetComponent<Attacker>().AttackOn(gameObj);
        }
    }



}//CLASS
