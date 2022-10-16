using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public enum GameState { menu, levelSelect, gamePlay, pause, levelVictory, levelDefeat, gameVictory }

    public static event Action<GameState> OnGameStateChanged;
    public GameState state;
    public GameObject pauseUI;
    public GameObject ingredientManager;
    public int currentScore;
    public Text Score;
    public PlayerControls player;

    public List<GameObject> ingredients;
    public Dictionary<string, Level> levels;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
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
        UpdateState(GameState.menu);

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
    
}


