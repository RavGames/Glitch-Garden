using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    private float speed = 0f;


    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    //this function will be called from animation event placed on the Lizard walk animation
    private void SetMovementSpeed(float moveSpeed)
    {
        speed = moveSpeed;
    }

}//CLASS
