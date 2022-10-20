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
    [SerializeField] private Text score;
    public int playerScore;
    public int totalScore;
    public int highScore;

    private bool finished;
    [SerializeField] private GameObject[] runes;
    void Start()
    {
        finished = false;
        playerScore = 0;
        highScore = 0;
        pauseMenu.SetActive(false);
        levelResult.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (playerScore == 80 && finished == false)
        {
            ShowLevelVictory();
            finished = true;
        }
    }


    public void UpdateScore(int points)
    {
        playerScore += points;
        score.text = playerScore.ToString();
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

    public void ShowLevelVictory()
    {
        levelResult.SetActive(true);
        foreach (GameObject rune in runes)
            rune.SetActive(false);
        ShowRunesAchieved();
    }

    public void LoadScene(string name)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(name);
    }

    public void ShowRunesAchieved()
    {
        float percentage = (float)(playerScore / totalScore);
        if (percentage >= 0.33f && percentage < 0.66f)
        {
            runes[0].SetActive(true);
        }
        else if (percentage >= 0.66f && percentage < 0.9f)
        {
            runes[0].SetActive(true);
            runes[1].SetActive(true);
        }
        else if (percentage >= 0.9f)
        {
            runes[0].SetActive(true);
            runes[1].SetActive(true);
            runes[2].SetActive(true);
        }
    }
    
}
