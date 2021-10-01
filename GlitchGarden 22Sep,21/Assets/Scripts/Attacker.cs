using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    private float speed = 0f;
    private GameObject currentDefender;

    private void Awake()
    {
        LevelController levelController = FindObjectOfType<LevelController>();
        if(levelController != null)
        {
            levelController.AttackersSpawned();
        }
        
    }

    private void OnDestroy()
    {
        LevelController levelController = FindObjectOfType<LevelController>();
        if (levelController != null)
        {
            levelController.AttackersKilled();
            levelController.HandleWinCondition();
        }
    }


    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        StopAttack();
    }

    //this function will be called from animation event placed on the Lizard walk animation
    private void SetMovementSpeed(float moveSpeed)
    {
        speed = moveSpeed;
    }

    private void StopAttack()
    {
        if(!currentDefender)
        {
            GetComponent<Animator>().SetBool("attack", false);
        }
    }


    public void AttackOn(GameObject defender)
    {
        //defender.GetComponent<Health>().ReduceHealth(30);
        GetComponent<Animator>().SetBool("attack", true);
        currentDefender = defender;
    }

    public void StrikeCurrentObject(float damage)
    {
        if(!currentDefender)
        {
            return;
        }
        Health health = currentDefender.GetComponent<Health>();
        if(health)
        {
            health.ReduceHealth(damage);
        }
    }

   



}//CLASS
