using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum CompletionStatus { locked, unlocked, oneStar, twoStar, threeStar}
public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textObj;
    public Level nextLevel;
    public int levelNum;
    public int playerScore;
    public bool levelCompleted;

    public CompletionStatus status;
    //public var status: CompletionStatus;
    void Start()
    {
        textObj.text = levelNum.ToString();
        switch(status)
        {
            case CompletionStatus.locked:
                break;
            case CompletionStatus.unlocked:
                break;
            case CompletionStatus.oneStar:
                break;
            case CompletionStatus.twoStar:
                break;
            case CompletionStatus.threeStar:
                break;
        }
    }

    
    // Update is called once per frame
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level_" + levelNum.ToString());
    }

    public void ChangeState(CompletionStatus newStatus)
    {
        switch(newStatus)
        {
            case CompletionStatus.locked:
                break;
            case CompletionStatus.unlocked:
                break;
            case CompletionStatus.oneStar:
                break;
            case CompletionStatus.twoStar:
                break;
            case CompletionStatus.threeStar:
                break;
        }
    }
}
