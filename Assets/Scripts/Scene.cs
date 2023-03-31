using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
