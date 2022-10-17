using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    static LevelManager instance;

    public Button[] levelButtons;
    
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        //All levels except level 1 will be locked.
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for(int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 2 > levelAt)
                levelButtons[i].interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Menu");
    }
}
