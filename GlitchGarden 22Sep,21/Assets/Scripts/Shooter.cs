using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;

    public void Fire()
    {
        GameObject bullet = Instantiate(projectile,
                            gun.transform.position,
                            Quaternion.identity) as GameObject;
    }


}//CLASS
