using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public enum GameState { gamePlay, pause, levelVictory, levelDefeat}

    public static event Action<GameState> OnGameStateChanged;
    public GameState state;
    public GameObject pauseUI;
    public GameObject ingredientManager;
    public int currentScore;
    public Text score;


    private List<GameObject> ingredients;


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

            case GameState.gamePlay:
                break;
            case GameState.pause:
                break;
            case GameState.levelVictory:
                break;
            case GameState.levelDefeat:
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
}


