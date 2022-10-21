using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngredientLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    //Don't delete this Eliott
    //It shows what's gonna launch next and it will help streamline future levels
    //even if it's not in player manager

    //fields for listing all the ingredients, i'm tryna make
    //this the script for every level
    public GameObject greenIngredient;
    public GameObject redIngredient;
    public GameObject blueIngredient;
    public GameObject yellowIngredient;

    public GameObject nextIngredient;

    public GameObject launcher;
    
    private Scene currentScene;

    //will make this an int stack cause it'll make it easier to code levels
    //match integer to a particular ingredient
    //0 - green
    //1 - red
    //2 - blue
    //3 - yellow
    public Stack<int> ingredientStackLevelOne;
    void Start()
    {
        ingredientStackLevelOne = new Stack<int>();
        //fill up the ingredient list with greens for level one
        for(int i = 0; i < 4; i++)
        {
            ingredientStackLevelOne.Push(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //checks level then checks corresponding ingredient list
        currentScene = SceneManager.GetActiveScene();
        string currentSceneName = currentScene.name;
        if(currentSceneName == "Level_1")
        {
            if(ingredientStackLevelOne.Count != 0)
            {
                if (ingredientStackLevelOne.Peek() == 0)
                    nextIngredient.GetComponent<Renderer>().material.color = new Color(0, 255, 0);

                else if (ingredientStackLevelOne.Peek() == 1)
                    nextIngredient.GetComponent<Renderer>().material.color = new Color(255, 0, 0);

                else if (ingredientStackLevelOne.Peek() == 2)
                    nextIngredient.GetComponent<Renderer>().material.color = new Color(0, 0, 255);

                else if (ingredientStackLevelOne.Peek() == 3)
                    nextIngredient.GetComponent<Renderer>().material.color = new Color(255, 255, 0);

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    //doing it like this so popping the ingredient affects the main guy
                    ingredientStackLevelOne = IngredientLaunch(ingredientStackLevelOne);
                }
            }

            else
            {
                nextIngredient.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            }
        }  

        /*
         * if(currentSceneName == "Level_2"
         */
    }

    /// <summary>
    /// To launch the ingredients, can call this method no matter 
    /// what level it is, instead of having to rewrite code.
    /// </summary>
    Stack<int> IngredientLaunch(Stack<int> ingredientStack)
    {
        if(ingredientStack.Peek() == 0)
        {
            GameObject greenIng = Instantiate(greenIngredient, 
                                              new Vector2(launcher.transform.position.x, launcher.transform.position.y),
                                              Quaternion.identity);
            ingredientStack.Pop();
        }

        else if(ingredientStack.Peek() == 1)
        {
            GameObject redIng = Instantiate(redIngredient,
                                            new Vector2(launcher.transform.position.x, launcher.transform.position.y),
                                            Quaternion.identity);
            ingredientStack.Pop();
        }

        else if(ingredientStack.Peek() == 2)
        {
            GameObject blueIng = Instantiate(blueIngredient,
                                             new Vector2(launcher.transform.position.x, launcher.transform.position.y),
                                             Quaternion.identity);
            ingredientStack.Pop();
        }

        else if(ingredientStack.Peek() == 3)
        {
            GameObject yellowIng = Instantiate(yellowIngredient,
                                               new Vector2(launcher.transform.position.x, launcher.transform.position.y),
                                               Quaternion.identity);
            ingredientStack.Pop();
        }

        return ingredientStack;
    }
}
