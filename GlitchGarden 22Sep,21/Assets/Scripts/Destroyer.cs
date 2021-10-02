using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
       //if(otherCollider.gameObject.GetComponent<Attacker>())
       // {
       //     Destroy(otherCollider.gameObject);
       // }

       // Projectile projectile = otherCollider.gameObject.GetComponent<Projectile>();
       // if(!projectile)
       // {
       //     return;
       // }
       // else
       // {
       //     Destroy(projectile);
       // }

        if(otherCollider.gameObject)
        {
            Destroy(otherCollider.gameObject);
            FindObjectOfType<DisplayLives>().LivesLost(1f);
        }



    }


}//CLASS
