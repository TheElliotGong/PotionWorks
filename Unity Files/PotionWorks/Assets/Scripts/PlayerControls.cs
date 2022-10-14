using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject ingredient;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GearControls();
        SpawnIngredients();
    }
    
    public void GearControls()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 80 * Time.deltaTime), Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -80 * Time.deltaTime), Space.World);
        }
    }

    public void SpawnIngredients()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newIngredient = Instantiate(ingredient, new Vector2(x, y), Quaternion.identity);
        }
    }
}
