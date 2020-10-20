using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ennemiBase : MonoBehaviour
{

    //référence au agent AI
    public NavMeshAgent agent;


    //référence au tag qui sonts sur les personnages joueurs
    public string tagJoueur;

    //tableau dans lequel sera initialisé tous les joueus
    private GameObject[] lesJoueurs;



    IEnumerator Start()
    {
        //on initialise par défaut le tag joueur, on peut le changer dans l'inspecteur plus tard
        tagJoueur = "joueur";

        // on va chercher tous les gameobjects de personnage joueurs
        lesJoueurs = GameObject.FindGameObjectsWithTag(tagJoueur);

        //on démare une coroutine qui activera le AI dans 1 seconde, 
        // le temps de laisser le navmesh se construire dans le niveau
        yield return StartCoroutine("ActiverAi");

    }

    //méthode pour attendre 1 seconde avant d'activer le AI
    IEnumerator ActiverAi()
    {
        yield return new WaitForSecondsRealtime(1f);
        agent.enabled = true;
    }

    void Update()
    {
        //si le AI est activé
        if (agent)
        {
            //pour chaque joueur
            foreach (GameObject joueur in lesJoueurs)
            {
                //calculer la distance entre le joueur et l'ennemi
                float distance = Vector3.Distance(transform.position, joueur.transform.position);

                //si la distance est plus petite que 50
                if (distance <= 50)
                {
                    //marcher en direction du joueur
                    agent.SetDestination(joueur.transform.position);
                }
            }
        }

    }
}
