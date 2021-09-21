using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviours : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
    public void OnNextButtonPressed()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

    public void OnPrevButtonPressed()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene - 1 <= 0)
        {
            currentScene = 0;
        } else
        {
            currentScene -= 1;
        }
        SceneManager.LoadScene(currentScene);

    }


}
