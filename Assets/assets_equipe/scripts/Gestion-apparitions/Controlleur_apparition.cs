using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlleur_apparition : MonoBehaviour
{
    private List<GameObject> pointsApparition;
    
    void Start()
    {
        foreach (var point in transform)
        {
            print(point);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
