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
    public bool unlocked;
    public bool completed;
    public GameObject potions;
    public Sprite[] potionSprites;
    public Sprite ButtonImage;
    void Start()
    {
        unlocked = LevelManager.instance.unlocked[levelNum - 1];
        playerScore = LevelManager.instance.levelScores[levelNum - 1];
        completed = LevelManager.instance.completed[levelNum - 1];
        UpdateImage();
        if(unlocked == false)
        {
            gameObject.GetComponent<Button>().interactable = false;
            ColorBlock colors = gameObject.GetComponent<Button>().colors;
            Color disabledColor = colors.disabledColor;
            disabledColor.a = 1;
            colors.disabledColor = disabledColor;
            gameObject.GetComponent<Button>().colors = colors;
        }
            
    }
    // Update is called once per frame
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level_" + levelNum.ToString());
    }

    public void UpdateImage()
    {
        //Check if a level has been unlocked and completed.
        if(unlocked == true && completed == true)
        {
            textObj.text = levelNum.ToString();
            gameObject.GetComponent<Image>().sprite = ButtonImage;
            if(playerScore > 0)
            { 
                float percentage = (float)(playerScore / maxScore);
                potions.GetComponentInChildren<Image>().sprite = potionSprites[0];
                if(percentage >= 0.33f )
                {
                    if(percentage >= 0.66f)
                    {
                        potions.GetComponentInChildren<Image>().sprite = potionSprites[1];
                    }
                    if (percentage >= 0.9f)
                    {
                        potions.GetComponentInChildren<Image>().sprite = potionSprites[2];
                    }
                }
            }
        }
    }

}
