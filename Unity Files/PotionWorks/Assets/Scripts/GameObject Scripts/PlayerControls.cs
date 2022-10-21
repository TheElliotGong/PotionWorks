using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    
    public List<GameObject> gears;
 
    public GameObject ingredientLauncher;
    private int index;
    public List<Transform> ingredientList;
    // Start is called before the first frame update
    void Start()
    {

       
    }

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

    public void SpawnIngredient()
    {
        if(index < ingredientList.Count)
        {
            //ingredientList[index].transform.position = new Vector3(-210, 350, 0.5f);
            ingredientList[index].gameObject.SetActive(true);
            index++;
             
        }
    }


}
