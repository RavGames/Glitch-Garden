using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject particleEffects;

    public void ReduceHealth(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            ShowDeathEffect();
            Destroy(gameObject);
        }
    }

    private void ShowDeathEffect()
    {
        GameObject vfx = Instantiate(particleEffects,
                                    transform.position,
                                    Quaternion.identity) as GameObject;

        Destroy(gameObject,2f);
    }




}//CLASS
