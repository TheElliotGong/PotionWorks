using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public enum GameState { menu, levelSelect, gamePlay, pause, levelVictory, levelDefeat, gameVictory}

    public static event Action<GameState> OnGameStateChanged;
    public GameState state;
   
    public int currentScore;
    public Text score; 
    public GameObject pauseUI;
    public GameObject ingredientManager;


    private List<GameObject> ingredients;

    public static GameManager instance;

    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void UpdateState(GameState newState)
    {
        switch(newState)
        {
            case GameState.menu:
                break;
            case GameState.levelSelect:
                break;
            case GameState.gamePlay:
                break;
            case GameState.pause:
                break;
            case GameState.levelVictory:
                break;
            case GameState.levelDefeat:
                break;
            case GameState.gameVictory:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        OnGameStateChanged?.Invoke(newState);
    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case GameState.menu:
                break;
            case GameState.levelSelect:
                break;
            case GameState.gamePlay:

                break;
            case GameState.pause:
                break;
            case GameState.levelVictory:
                break;
            case GameState.levelDefeat:
                break;
            case GameState.gameVictory:
                break;
        }
    }
    
    public void AddScore(GameObject ingredient)
    {

    }
}


