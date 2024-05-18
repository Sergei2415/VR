using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Script2 : MonoBehaviour
{
    private bool isPaused = false;

    public void PauseProject()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
            // здесь вы можете добавить код для отображения панели паузы
        }
        else
        {
            Time.timeScale = 1;
            // здесь вы можете добавить код для скрытия панели паузы
        }
    }

    // Update is called once per frame
    public void RestartProject()
    {
        Application.LoadLevel("SampleScene");
    }

    public void ExitProject()
    {
        Application.Quit();
    }
}
