using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back_Button_UI : MonoBehaviour
{
    [SerializeField] private string state = "Menu";

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(state);
    }
}
