using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
     private Defenders defenders;

    private void OnMouseDown()
    {
        AttemptToSpawnADenderAt(GetMousePos());
    }


    private void AttemptToSpawnADenderAt(Vector2 gridPos)
    {
        
        if(!defenders)
        {
            return;
        }
        float defendersCost = defenders.GetStarCost();
        StarDisplay starDisplay = FindObjectOfType<StarDisplay>();

        if (starDisplay.hasStars(defendersCost))
        {
            SpawnDefenders(gridPos);
            starDisplay.SpendStars(defendersCost);
        }
    }



    private Vector2 GetMousePos()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //Debug.Log("Current POs of mouse : " + mousePos);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 defenderPos = SnapToGrid(worldPos);
        return defenderPos;
    }

    private Vector2 SnapToGrid(Vector2 gridPos)
    {
        float x = Mathf.RoundToInt(gridPos.x);
        float y = Mathf.RoundToInt(gridPos.y);
        return new Vector2(x, y);
    }

    private void SpawnDefenders(Vector2 pos)
    {
        Defenders gameObject = Instantiate(defenders,
                                pos, 
                                Quaternion.identity) as Defenders;
    }

    public void SetSelectedDefender(Defenders defender)
    {
        defenders = defender;
    }

}
