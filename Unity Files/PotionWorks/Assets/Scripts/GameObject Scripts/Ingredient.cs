using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Note this new line is needed for UI
using System;

public class Ingredient : MonoBehaviour
{
    // Start is called before the first frame update
    private UIManager ui;
    public GameObject trap;
    public GameObject pot;
    public int points;
    private void Start()
    {
        ui = GameObject.Find("HUD").GetComponent<UIManager>();
        if (ui == null)
            Debug.Log("HUD not found!");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == trap.tag)
        {
            Destroy(gameObject);
        }
        else if(collision.gameObject.name == "Cauldron")
        {
            AddScore();
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Destroy the ingredient if it goes off the screen.
    /// </summary>
    private void OnBecameInvisible()
    {
        
        Destroy(gameObject);
    }

    public void AddScore()
    {
        if(ui != null)
        {
            ui.UpdateScore(points);
        }
    }
}
