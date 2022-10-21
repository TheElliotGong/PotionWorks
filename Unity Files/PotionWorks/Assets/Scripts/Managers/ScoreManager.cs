using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] levelScores;
    public bool[] locked;
    public static ScoreManager instance;

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

    public void SetLevelScore(int index, int score, bool completed)
    {
        levelScores[index] = score;
        locked[index] = completed;
    }


}
