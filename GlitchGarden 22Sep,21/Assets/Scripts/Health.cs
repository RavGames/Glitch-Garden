using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject particleEffect;
    private float period = 1f;

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
        if (!particleEffect) { return; }
        GameObject vfx = Instantiate(particleEffect, transform.position, transform.rotation) as GameObject;
        Destroy(vfx, period);
    }




}//CLASS
