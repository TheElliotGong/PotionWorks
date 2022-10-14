using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class IngredientScript : PlayableAsset
{
    // Factory method that generates a playable based on this asset
    public int points;
    enum weakness {red, green, blue };
    

    void Start()
    {

    }

    void Update()
    {

    }
    
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
    {
        return Playable.Create(graph);
    }
}
