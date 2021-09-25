﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LEvelLoader : MonoBehaviour
{
    [SerializeField] float waitTime = 4f;

    private void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(Delay());
        }
    }


    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("StartGame");
    }

    public void LoadStartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }


    public void Quit()
    {
        Application.Quit();
    }





}//CLASS