using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker[] attackers;

    [SerializeField] float minTime = 1f;
    [SerializeField] float maxTime = 3f;
    [SerializeField] bool spawn = true;


    private IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            Spawn();
        }
    }



    private void SpawnAttackers(Attacker attacker)
    {
        Attacker newAttacker = Instantiate(attacker,
                                transform.position,
                                Quaternion.identity) as Attacker;
        newAttacker.transform.parent = transform;
    }


    private void Spawn()
    {
        int attackerIndex = Random.Range(0, attackers.Length);
        SpawnAttackers(attackers[attackerIndex]);
    }

    
}//CLASS
