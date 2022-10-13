using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ingredientPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //i'll hard code the ingredient spawn position for now
            GameObject newIngredient = Instantiate(ingredientPrefab, new Vector2(6.1f, 120.0f), Quaternion.identity);
        }
    }
}
