using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseToMenu : MonoBehaviour
{

    public GameObject Camera;

    public bool loaded = false;
    public float time = 0;



    private void Update()
    {
        time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Escape) && loaded == false && time >= 5)
        {

            SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Additive);
            //SceneManager.UnloadSceneAsync("Game", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
            loaded = true;
            Camera.SetActive(false);
        }

        if(SceneManager.sceneCount == 1)
        {
            loaded = false;
            Camera.SetActive(true);
        }
    }
}
