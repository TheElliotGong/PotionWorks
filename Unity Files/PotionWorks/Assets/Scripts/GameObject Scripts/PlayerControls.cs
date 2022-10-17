using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public GameObject ingredients;
    public GameObject ingredientLauncher;


    private int index;
    public List<GameObject> ingredientList;
    private bool AllIngredientsSpawned;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.identity;
        foreach(Transform child in ingredients.transform)
        {
            //child.transform.position = new Vector3(0, 200, 0.5f);
            child.gameObject.SetActive(false);
            ingredientList.Add(child.gameObject);  
        }
        index = 0;
        AllIngredientsSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        TurnGears();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    public void TurnGears()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnIngredient();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 80 * Time.deltaTime), Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -80 * Time.deltaTime), Space.World);
        }
        
    }

    public void SpawnIngredient()
    {
        if(index < ingredientList.Count && AllIngredientsSpawned == false)
        {
            ingredientList[index].SetActive(true);
            index++;
            if (index == ingredientList.Count)
            {
                AllIngredientsSpawned = true;
            }   
        }
    }


}
