using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void playGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void Exit() {
        Application.Quit();
    }
}
