using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{

    public void firstTime()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void startGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
