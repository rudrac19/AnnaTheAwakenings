using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }



    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
