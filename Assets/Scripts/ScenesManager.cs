using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void ChangeScene(int indScene)
    {
        SceneManager.LoadScene(indScene);
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
}
