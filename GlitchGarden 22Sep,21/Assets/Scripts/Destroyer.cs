using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] float damage = 1f;

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
       
        if(otherCollider.gameObject.GetComponent<Attacker>())
        {
            Destroy(otherCollider.gameObject);
            FindObjectOfType<DisplayLives>().LivesLost(damage);
        }



    }


}//CLASS
