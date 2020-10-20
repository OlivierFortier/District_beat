using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ennemiBase : MonoBehaviour
{

    public NavMeshAgent agent;


    public string tagJoueur;

    private GameObject[] lesJoueurs;

    // Start is called before the first frame update
    void Start()
    {
        tagJoueur = "joueur";

        lesJoueurs = GameObject.FindGameObjectsWithTag(tagJoueur);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject joueur in lesJoueurs)
        {
            float distance = Vector3.Distance(transform.position, joueur.transform.position);

            if (distance <= 50)
            {
                agent.SetDestination(joueur.transform.position);
            }
        }

    }
}
