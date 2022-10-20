using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public struct LevelScore
    {
        public string name;
        public int score;
    }
    public List<LevelScore> levelScores;
    static ScoreManager instance;
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLevelScore(string levelName, int score)
    {
        LevelScore level = new LevelScore { name = levelName, score = score };
        levelScores.Add(level);
    }


}
