using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public enum GameState {gamePlay, pause, levelVictory, levelDefeat}


    public GameState state;
    public int currentScore;
    public Text score; 
    public GameObject pauseUI;
    public GameObject ingredientManager;


    private List<GameObject> ingredients;

    public static GameManager instance;

    public static GameManager Instance { get; private set; }
    
    /*private void Awake()

    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }*/

    public void UpdateState(GameState newState)
    {
        switch(newState)
        {
            case GameState.gamePlay:

                break;
            case GameState.pause:
                break;
            case GameState.levelVictory:
                break;
            case GameState.levelDefeat:
                break;
        }
    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case GameState.gamePlay:

                break;
            case GameState.pause:
                break;
            case GameState.levelVictory:
                break;
            case GameState.levelDefeat:
                break;

        }
    }
    
    public void AddScore(GameObject ingredient)
    {

    }
    public void WinLevel()
    {

    }
    public void ClearLevel()
    {

    }

    
}


