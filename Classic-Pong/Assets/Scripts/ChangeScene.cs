using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //Moves to a specific scene when the ID of the scene is specified
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    //Quits application
    public void Quit()
    {
        Application.Quit();
    }
}
