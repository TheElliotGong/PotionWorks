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
        public bool completed;
        public bool unlocked;
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

        LevelScore level = new LevelScore { completed = false, score = 0 };

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLevelScore(bool completed, int score)
    {
        LevelScore level = new LevelScore { completed = true, score = score };
        levelScores.Add(level);
    }


}
