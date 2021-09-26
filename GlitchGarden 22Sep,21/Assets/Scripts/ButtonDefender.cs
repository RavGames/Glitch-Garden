using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDefender : MonoBehaviour
{
    [SerializeField] Defenders defenders;


    private void OnMouseDown()
    {
        SpriteColorChange();
    }


    private void SpriteColorChange()
    {
        var buttons = FindObjectsOfType<ButtonDefender>();

        foreach(ButtonDefender button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(255,255,255,100);
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenders);
    }



}//CLASS
