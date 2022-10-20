using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    static LevelManager instance;

    public Dictionary<string, int> levelScores;
    
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
