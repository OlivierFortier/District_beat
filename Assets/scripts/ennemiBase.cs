using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ennemiBase : MonoBehaviour
{

    public NavMeshAgent agent;

    [SerializeField]
    public GameObject refJoueur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, refJoueur.transform.position);

        if(distance <= 50) {
            agent.SetDestination(refJoueur.transform.position);
        }
        
    }
}
