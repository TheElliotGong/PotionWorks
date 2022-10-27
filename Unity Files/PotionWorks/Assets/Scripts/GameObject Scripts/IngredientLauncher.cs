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

    public bool levelDone;
    
    private Scene currentScene;

    //will make this an int stack cause it'll make it easier to code levels
    //match integer to a particular ingredient
    //0 - green
    //1 - red
    //2 - blue
    //3 - yellow
    public Stack<int> ingredientStackLevelOne;
    public Stack<int> ingredientStackLevelTwo;

    //Stacks of the actual item, when every thing is destroyed it will be null, right?
    public Stack<GameObject> gOIngredientStack;

    //i looked it up and found out that 
    //on destruction the game object doesn't go away, just sets itself to null
    //so cant just rely on count have to check this way
    bool allIngredientsGone;
    void Start()
    {
        ingredientStackLevelOne = new Stack<int>();
        ingredientStackLevelTwo = new Stack<int>();
        gOIngredientStack = new Stack<GameObject>();
        //fill up the ingredient list with greens for level one
        for(int i = 0; i < 4; i++)
        {
            ingredientStackLevelOne.Push(0);
        }

        //assign ingredient list for level two
        ingredientStackLevelTwo.Push(0);
        ingredientStackLevelTwo.Push(1);
        ingredientStackLevelTwo.Push(1);
        ingredientStackLevelTwo.Push(0);

        levelDone = false;
        allIngredientsGone = false;
    }

    // Update is called once per frame
    void Update()
    {
        //checks level then checks corresponding ingredient list
        currentScene = SceneManager.GetActiveScene();
        Debug.Log(currentScene.name);
        string currentSceneName = currentScene.name;
        if(currentSceneName == "Level_1")
        {
            ingredientStackLevelOne = NextIngredientShow(ingredientStackLevelOne);
        }


        if (currentSceneName == "Level_2")
        {
            //i dont think i need to clear the game object ingredient stack as it clears itself as level ends
            ingredientStackLevelTwo = NextIngredientShow(ingredientStackLevelTwo);
        }


        Color white = new Color(255, 255, 255);

        allIngredientsGone = true;
        while(gOIngredientStack.Count != 0)
        {
            //if the top most is not null then it's not empty
            if(gOIngredientStack.Peek() != null)
            {
                allIngredientsGone = false;
                //the iteration will either break here or it'll break when count is 0 and allIngredientsGone will be true then
                break;
            }

            else
            {
                //if it is null then pop it off cause we don't need it anymore and check what's under it
                gOIngredientStack.Pop();
            }
        }
        if((nextIngredient.GetComponent<Renderer>().material.color == white) && allIngredientsGone)
        {
            levelDone = true;
        }
    }

    Stack<int> NextIngredientShow(Stack<int> ingredientStack)
    {
        if (ingredientStack.Count != 0)
        {
            if (ingredientStack.Peek() == 0)
                nextIngredient.GetComponent<Renderer>().material.color = new Color(0, 255, 0);

            else if (ingredientStack.Peek() == 1)
                nextIngredient.GetComponent<Renderer>().material.color = new Color(255, 0, 0);

            else if (ingredientStack.Peek() == 2)
                nextIngredient.GetComponent<Renderer>().material.color = new Color(0, 0, 255);

            else if (ingredientStack.Peek() == 3)
                nextIngredient.GetComponent<Renderer>().material.color = new Color(255, 255, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //doing it like this so popping the ingredient affects the main guy
                ingredientStack = IngredientLaunch(ingredientStack);
            }
        }

        else
        {
            nextIngredient.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        }

        return ingredientStack;
    }

    /// <summary>
    /// To launch the ingredients, can call this method no matter 
    /// what level it is, instead of having to rewrite code.
    /// </summary>
    Stack<int> IngredientLaunch(Stack<int> ingredientStack)
    {
        Vector3 spawnPosition = new Vector3(launcher.transform.position.x, launcher.transform.position.y, launcher.transform.position.z);
        if(ingredientStack.Peek() == 0)
        {
            GameObject greenIng = Instantiate(greenIngredient, 
                                              new Vector2(launcher.transform.position.x, launcher.transform.position.y),
                                              Quaternion.identity);
            gOIngredientStack.Push(greenIng);
            ingredientStack.Pop();
        }

        else if(ingredientStack.Peek() == 1)
        {
            GameObject redIng = Instantiate(redIngredient,
                                            new Vector2(launcher.transform.position.x, launcher.transform.position.y),
                                            Quaternion.identity);
            gOIngredientStack.Push(redIng);
            ingredientStack.Pop();
        }

        else if(ingredientStack.Peek() == 2)
        {
            GameObject blueIng = Instantiate(blueIngredient,
                                             new Vector2(launcher.transform.position.x, launcher.transform.position.y),
                                             Quaternion.identity);
            gOIngredientStack.Push(blueIng);
            ingredientStack.Pop();
        }

        else if(ingredientStack.Peek() == 3)
        {
            GameObject yellowIng = Instantiate(yellowIngredient,
                                               new Vector2(launcher.transform.position.x, launcher.transform.position.y),
                                               Quaternion.identity);
            gOIngredientStack.Push(yellowIng);
            ingredientStack.Pop();
        }

        return ingredientStack;
    }
}
