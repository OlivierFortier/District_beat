using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Olivier Fortier
// script qui permet de générer dynamiquement le navmesh avec les niveaux procédural
public class ConstructeurNavmesh : MonoBehaviour
{

    //référence aux gameobject qui composent la surface du sol marchable par les joueurs et AI
    public GameObject[] surfacesSol;

    //booléen pour déterminer si on veut ou non construire 1 seul navmesh ou 1 navmesh par section
    public bool construireUnSeulNavMesh;

    //référence au composant NavMesh de l'objet
    public NavMeshSurface solNav;

    void Start()
    {
        //si on ne veut pas construire un seul navmesh
        if (!construireUnSeulNavMesh)
        {
            //trouver toutes les surfaces qui contiennent le tag sol et les mettre dans la variable
            surfacesSol = GameObject.FindGameObjectsWithTag("sol");

            //pour chaque surface trouvée
            foreach (GameObject surface in surfacesSol)
            {
                //si la surface possède un composant navmesh
                if (surface.GetComponent<NavMeshSurface>())
                {
                    //aller chercher la référence au composant navmesh
                    NavMeshSurface navmeshSurface = surface.GetComponent<NavMeshSurface>();
                    //nettoyer les données précédentes
                    navmeshSurface.RemoveData();
                    //construire le navmesh de la section
                    navmeshSurface.BuildNavMesh();
                }
            }
        }
        else
        {
            //si le composant navmesh de l'objet global est activé
            if (solNav)
            {
                //nettoyer les données précédentes
                solNav.RemoveData();
                //reconstruire le navmesh
                solNav.BuildNavMesh();
            }
        }
    }
}
