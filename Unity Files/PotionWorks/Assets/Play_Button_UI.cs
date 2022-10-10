using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button_UI : MonoBehaviour
{
    [SerializeField] private string gameLevel = "Level_Select";

    public void PlayGame()
    {
        SceneManager.LoadScene(gameLevel);
    }
    
}
