using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    [SerializeField] float delayInSeconds = 3;
    int currentSceneIndex = 1;

    public void Start()
    {

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitBeforeLoading());
        }


    }

    IEnumerator WaitBeforeLoading()
    {

        yield return new WaitForSeconds(delayInSeconds);

        LoadNextScene();

    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
