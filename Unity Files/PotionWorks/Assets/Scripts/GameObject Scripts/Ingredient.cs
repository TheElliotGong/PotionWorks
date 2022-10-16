using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Note this new line is needed for UI
using System;

public class Ingredient : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trap;
    public GameObject pot;
    public Text score;
    public int points;
    public byte weakness;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.tag == trap.tag)
        {
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
        
    }
}
