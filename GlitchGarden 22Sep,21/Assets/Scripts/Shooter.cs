﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    private AttackerSpawner myLaneSpawner;

     GameObject parentProjetcile;
    const string PARENT_PROJECTILE_KEY = "parentProjectile";


    private void Start()
    {
        SpawnAttackerLane();
        CreateParentProjectile();
    }

    private void CreateParentProjectile()
    {
        parentProjetcile = GameObject.Find(PARENT_PROJECTILE_KEY);

        if(!parentProjetcile)
        {
            parentProjetcile = new GameObject(PARENT_PROJECTILE_KEY);
        }
    }


    public void Fire()
    {
        GameObject bullet = Instantiate(projectile,
                            gun.transform.position,
                            Quaternion.identity) as GameObject;
        bullet.transform.parent = parentProjetcile.transform;
    }


    //public void SetMyAttackerLane()
    //{
    //    AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
    //    foreach(AttackerSpawner spawner in attackerSpawners)
    //    {
    //        bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y
    //                                - transform.position.y) <= Mathf.Epsilon);
    //        if(isCloseEnough)
    //        {
    //            myLaneSpawner = spawner;
    //        }
    //    }

    //}

    public void SpawnAttackerLane()
    {
        AttackerSpawner[] a = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in a)
        {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y)
                                    <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }

    }

    //private bool IsCloseEnough()
    //{
    //    if(myLaneSpawner.transform.childCount <= 0)
    //    {
    //        return false;
    //    }
    //    else
    //    {
    //        return true;
    //    }
    //}

    private bool IsCloseEnough()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    private void Update()
    {
        if(IsCloseEnough())
        {
            GetComponent<Animator>().SetBool("attack", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("attack", false);
        }
    }



}//CLASS
