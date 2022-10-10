using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;

    public void QuitGame()
    {
        Debug.Log("You quit the game!");
        Application.Quit();
    }
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
