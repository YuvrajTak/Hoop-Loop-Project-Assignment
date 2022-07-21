using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneHandler : MonoBehaviour
{
    
    public void changeScene()
    {
        SceneManager.LoadScene(1);
    }

    public void quitScene()
    {
        Application.Quit();
    }



}
