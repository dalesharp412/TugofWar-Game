using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseToMenu : MonoBehaviour
{
    public void sceneChange()
    {
        Debug.Log("Go to Main Menu");
        SceneManager.LoadScene("Main");
    }
}
