using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CombatDistance : MonoBehaviour
{
    public float tempsEntreAttaque;
    public float debutAttaque;
    public Animator animator;
    public GameObject refAttaqueArme;

    [HideInInspector] public GameObject attaqueArme;
    public GameObject mainQuiPrendArme;

    private void Start()
    {
        attaqueArme = Instantiate(refAttaqueArme, mainQuiPrendArme.transform);
        attaqueArme.transform.localPosition = new Vector3(0.03f, 0.14f, -0.07f);
    }

    void Update()
    {
        if (tempsEntreAttaque > 0)
        {
            tempsEntreAttaque -= Time.deltaTime;
            
        }

    }

    public void attaque()
    {
        if (tempsEntreAttaque <= 0)
        {
            animator.SetTrigger("attaque");
            tempsEntreAttaque = debutAttaque;

            //instancier le projectile (attaqueArme)

            //activer le collider du projectile

            //détruire le projectile lorsqu'il touche un mur ou un ennemi

        }

    }
}
