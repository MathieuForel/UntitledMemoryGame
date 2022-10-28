using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GamePause : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Time.timeScale = 0;
    }

    void OnSceneUnloaded(Scene scene)
    {
        Time.timeScale = 1;
    }
}
