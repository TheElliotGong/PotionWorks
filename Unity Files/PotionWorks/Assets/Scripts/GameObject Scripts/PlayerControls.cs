using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    
    public List<GameObject> gears;
    private int index;
    public List<Transform> ingredientList;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        TurnGears();
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SpawnIngredient();
        //}
    }

    public void TurnGears()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            foreach(GameObject gear in gears)
                gear.transform.Rotate(new Vector3(0, 0, 80 * Time.deltaTime), Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            foreach (GameObject gear in gears)
                gear.transform.Rotate(new Vector3(0, 0, -80 * Time.deltaTime), Space.World);
        }
        
    }

}
