using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ConstructeurNavmesh : MonoBehaviour
{

    public GameObject[] surfacesSol;

    public bool testAllo;

    public NavMeshSurface solNav;

    // Start is called before the first frame update
    void Start()
    {
        if (!testAllo)
        {
            surfacesSol = GameObject.FindGameObjectsWithTag("sol");

            foreach (GameObject surface in surfacesSol)
            {
                if (surface.GetComponent<NavMeshSurface>())
                {
                    NavMeshSurface navmeshSurface = surface.GetComponent<NavMeshSurface>();
                    navmeshSurface.BuildNavMesh();
                }
            }
        }
        else
        {
            if (solNav) { solNav.BuildNavMesh(); }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
