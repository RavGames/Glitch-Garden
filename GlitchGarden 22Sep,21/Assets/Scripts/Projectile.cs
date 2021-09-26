using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 50f;


    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var attacker = otherCollider.gameObject.GetComponent<Attacker>();

        Health enemyHealth = otherCollider.gameObject.GetComponent<Health>();

        if(attacker && enemyHealth)
        {
            enemyHealth.ReduceHealth(damage);
            Destroy(gameObject);
        }
        else
        {
            return;
        }
        
    }


}//CLASS
