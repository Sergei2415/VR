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
            // ����� �� ������ �������� ��� ��� ����������� ������ �����
        }
        else
        {
            Time.timeScale = 1;
            // ����� �� ������ �������� ��� ��� ������� ������ �����
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
