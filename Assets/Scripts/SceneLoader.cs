using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    [SerializeField]
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        AndroidNativeFunctions.ShowAlert("Are you sure you want to quit?", "Quit", "yes", "Cancel","", AlertQuitAction,AlertNegativeAction);
    }

    void AlertQuitAction(DialogInterface w)
    {
        Application.Quit();
    }

    void AlertNegativeAction(DialogInterface w)
    {
    }
}
