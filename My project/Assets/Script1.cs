using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartProject()
    {
        UnityEngine.Debug.Log("Button was clicked!");

        Application.LoadLevel("SampleScene");
    }

    // Update is called once per frame
    public void ExitProject()
    {
        Application.Quit();
    }


}
