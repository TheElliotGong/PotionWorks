using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomatedGear : MonoBehaviour
{
    [SerializeField] public List<GameObject> gears;

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject gear in gears)
            gear.transform.Rotate(new Vector3(0, 0, 80 * Time.deltaTime), Space.World);
    }
}
