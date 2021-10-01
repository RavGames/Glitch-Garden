using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    private Slider canvasSlider;
    [Tooltip("Time In Sec")]
    [SerializeField] float liveTime = 10f;

    [SerializeField] bool triggeredLevelFinished = false;

    private void Start()
    {
        canvasSlider = GetComponent<Slider>();
    }

    private void Update()
    {
        if(triggeredLevelFinished)
        {
            return;
        }
        
        canvasSlider.value = Time.timeSinceLevelLoad / liveTime;

        bool levelTime = Time.timeSinceLevelLoad >= liveTime;

        if(levelTime)
        {
            triggeredLevelFinished = true;
            Debug.Log("time Expired");
            FindObjectOfType<LevelController>().LevelTimerEnd();
            
        }

    }





}//CLASS
