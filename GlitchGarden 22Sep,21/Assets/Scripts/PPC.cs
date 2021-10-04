using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPC : MonoBehaviour
{

    const string MASTER_VOL_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOL = 0f;
    const float MAX_VOL = 1f;


    const float MIN_DIFFICULTY = 0f;
    const float MAX_DIFFICULTY = 2f;



    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOL && volume <= MAX_VOL)
        {
            Debug.Log("Master vol set to : " + volume);
            PlayerPrefs.SetFloat(MASTER_VOL_KEY, volume);
        }
        else
        {
            Debug.LogError("Master vol is Out Of Range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOL_KEY);
    }




    public static void SetMasterDifficulty(float difficultyLevel)
    {
        if (difficultyLevel >= MIN_DIFFICULTY && difficultyLevel <= MAX_DIFFICULTY)
        {
            Debug.Log("Master diff set to : " + difficultyLevel);
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficultyLevel);
        }
        else
        {
            Debug.LogError("Difficulty Is out of range");
        }
    }



    public static float GetMasterDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }



}//CLASS
