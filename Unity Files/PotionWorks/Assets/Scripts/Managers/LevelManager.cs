using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Level[] levelButtons;

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
