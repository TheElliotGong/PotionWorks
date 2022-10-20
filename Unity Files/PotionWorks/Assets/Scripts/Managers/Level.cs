using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textObj; 
    public int levelNum;
    public int playerScore;
    public int maxScore;
    public bool levelCompleted;
    public bool locked;
    public GameObject[] potions;



    void Start()
    {
        textObj.text = levelNum.ToString();
        
    }
    // Update is called once per frame
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level_" + levelNum.ToString());
    }

    public void UpdateImage()
    {
        if(locked == false)
        {

        }
        else
        {

        }
    }

}
