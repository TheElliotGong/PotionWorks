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
    [SerializeField] private Progress_Bar cauldronBar;
    [SerializeField] private Text score;
    
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
            Debug.Log("This code runs bruv");
            ShowLevelResult();
            finished = true;
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
        SceneManager.LoadScene(name);
        launcher.levelDone = false;
        finished = false;
    }

    public void ShowPotionsAchieved()
    {
        float percentage = (float)(playerScore) / (float)(maxScore);
        Debug.Log(percentage);
        if (percentage >= 0.33f )
        {
            potions[0].GetComponent<Image>().sprite = potionImages[1];
            if(percentage >= 0.66f)
                potions[1].GetComponent<Image>().sprite = potionImages[1];
            if(percentage >= 0.9f)
                potions[2].GetComponent<Image>().sprite = potionImages[1];
            LevelManager.instance.SetLevelScore(levelNum - 1, highScore, true);
            
        }
        else
        {
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
