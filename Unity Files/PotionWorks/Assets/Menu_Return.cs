using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_Return : MonoBehaviour
{
    [SerializeField] private string state = "Menu";

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(state);
    }
}
