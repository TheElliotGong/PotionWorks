using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;


public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject levelResult;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject nextButton;
    [SerializeField] private Progress_Bar cauldronBar;
    [SerializeField] private TextMesh score;
    
    public int playerScore;
    public int maxScore;
    public int highScore;
    public int levelNum;
    
    private IngredientLauncher launcher;
    private bool finished;
    [SerializeField] private GameObject[] potions;
    [SerializeField] private Sprite[] potionImages;
    void Start()
    {
        AudioManager.instance.SetAudio(1);
        finished = false;
        playerScore = 0;
        highScore = LevelManager.instance.levelScores[levelNum - 1];
        pauseMenu.SetActive(false);
        levelResult.SetActive(false);

        launcher = GameObject.Find("Ingredient_Launcher").GetComponent<IngredientLauncher>();
        if (launcher == null)
            Debug.Log("Ingredient Launcher not found!");
    }

    // Update is called once per frame
    void Update()
    {
        //for now it's just for level one i'll update it to accomodate more levels once i know it works
        if (launcher.levelDone && finished == false)
        {
            finished = true;
            ShowLevelResult();
        }
    }
    public void UpdateScore(int points)
    {

        playerScore += points;
        score.text = playerScore.ToString();
        cauldronBar.AddProgress((float)points);
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowLevelResult()
    {
        
        if (playerScore >= highScore)
        {
            highScore = playerScore;
        }
        levelResult.SetActive(true);
        ShowPotionsAchieved();
        

    }

    public void LoadScene(string name)
    {
        Time.timeScale = 1f;
        if (name == "Level_Select" || name == "Menu")
            AudioManager.instance.SetAudio(0);
        
        SceneManager.LoadScene(name);
        launcher.levelDone = false;
        finished = false;
    }

    public void ShowPotionsAchieved()
    {
        float currentPercentage = (float)(playerScore) / (float)(maxScore);
        float highScorePercentage = 0f;
        //update the player's high score percentage if the high score is actually greater than 0.
        if(highScore > 0)
        {
            highScorePercentage = (float)(highScore) / (float)(maxScore);
        }
        //Show star rating if the current score is at least a third of the max possible score.
        if (currentPercentage >= 0.33f )
        {
            nextButton.SetActive(true);
            AudioManager.instance.SetAudio(2);
            potions[0].GetComponent<Image>().sprite = potionImages[1];
            if(currentPercentage >= 0.66f)
                potions[1].GetComponent<Image>().sprite = potionImages[1];
            if(currentPercentage >= 0.9f)
                potions[2].GetComponent<Image>().sprite = potionImages[1];
            LevelManager.instance.SetLevelScore(levelNum - 1, highScore, true);
            
            
        }
        //Make sure that the player's score is saved.
        else
        {
            nextButton.SetActive(false);
            //Only set completed as false if the high score isn't greater than 33 percent.
            if(highScorePercentage < 0.33f)
            LevelManager.instance.SetLevelScore(levelNum - 1, highScore, false);
        }



    }
    /// <summary>
    /// This method checks if all levels have been completed.
    /// </summary>
    public void CheckGameCompletion()
    {
        int levelsCompleted = 0;
        foreach(bool status in LevelManager.instance.completed)
        {
            if (status == true)
                levelsCompleted++;
        }
        if(levelsCompleted == LevelManager.instance.completed.Length)
        {

        }
    }
}
