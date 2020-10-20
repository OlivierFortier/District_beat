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
    IEnumerator Start()
    {
        tagJoueur = "joueur";

        lesJoueurs = GameObject.FindGameObjectsWithTag(tagJoueur);

        yield return StartCoroutine("ActiverAi");

    }

    IEnumerator ActiverAi() {
        yield return new WaitForSecondsRealtime(1f);
        agent.enabled = true;
    }



    // Update is called once per frame
    void Update()
    {
        if (agent)
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
}
