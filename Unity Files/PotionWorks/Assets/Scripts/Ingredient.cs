using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trap;
    public GameObject pot;
    public GameObject score;
    public int points;
    public byte weakness;
    private byte typeOfTrap;
    private int scoreValue;
    
    void Start()
    {
        typeOfTrap = trap.GetComponent<Trap>().trapType;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CheckCollision()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (typeOfTrap == weakness && collision.gameObject == trap)
        {
            Destroy(gameObject);
        }


    }


    public void AddScore()
    {
        
    }
}
