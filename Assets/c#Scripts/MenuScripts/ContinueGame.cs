using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueGame : MonoBehaviour
{
    void Start()
    {
        SceneManager.UnloadSceneAsync("Menu");
    }
}

