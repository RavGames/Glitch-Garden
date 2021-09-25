using System.Collections;
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


}//CLASS
