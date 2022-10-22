using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// This scripts handles buttons across all the scenes. This extends to main menu, 
/// </summary>
public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName; //The name of the scene/level we want to load.
    public string levelName;//The pause menu that will pop up when we click the pause button.
    
    public void QuitGame()
    {
        Debug.Log("You quit the game!");
        Application.Quit();
    }
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(levelName);
    }


    void Update()
    {
        
    }
}
