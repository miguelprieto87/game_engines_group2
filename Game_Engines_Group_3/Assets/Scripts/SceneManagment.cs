using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{

    public void playGame(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void quitGame()
    {
        Application.Quit();
    }


}
