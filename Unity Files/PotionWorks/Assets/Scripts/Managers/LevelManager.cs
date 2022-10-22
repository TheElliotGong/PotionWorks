using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] levelScores;
    public bool[] unlocked;
    public bool[] completed;

    
    
    public static LevelManager instance;
    /// <summary>
    /// Ensures that the script/gameobject doesn't get destroyed when loading a new scene.
    /// </summary>
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    /// <summary>
    /// Record the player's score for a desired level.
    /// </summary>
    /// <param name="index">The level that the player completed. </param>
    /// <param name="score">That player's high score.</param>
    /// <param name="completed">Determining if the level was completed or not.</param>
    public void SetLevelScore(int index, int score, bool completionStatus)
    {
        levelScores[index] = score;
        completed[index] = completionStatus; //Mark the current level as complete.
        unlocked[index + 1] = completionStatus; //Unlock the next level if current level is completed.
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Menu");
    }

}
