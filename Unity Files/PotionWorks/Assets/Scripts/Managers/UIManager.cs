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
    [SerializeField] private GameObject levelVictory;
    [SerializeField] private GameObject levelDefeat;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private int playerScore;
    [SerializeField] private Text score;
    void Start()
    {
        playerScore = 0;
        pauseMenu.SetActive(false);
        levelVictory.SetActive(false);
        levelDefeat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        levelVictory.SetActive(true);
    }

    public void ShowLevelDefeat()
    {
        levelDefeat.SetActive(true);
    }

    public void LoadScene(string name)
    {
        
        SceneManager.LoadScene(name);
    }

    
    
}
