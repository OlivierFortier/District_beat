using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CombatDistance : MonoBehaviour
{

    public bool estUnJoueur = false;
    public float tempsEntreAttaque;
    public float debutAttaque;
    public Animator animator;
    public GameObject refAttaqueArme;

    [HideInInspector] public GameObject attaqueArme;
    public GameObject mainQuiPrendArme;

    public Vector3 projectilePostionDepart;

    private void Start()
    {
        attaqueArme = Instantiate(refAttaqueArme, mainQuiPrendArme.transform);
        // attaqueArme.GetComponent<toucherEnnemi>().SetProjectile(true);
        attaqueArme.GetComponent<toucherEnnemi>().AssocierJoueurAuProjectile(estUnJoueur);
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
            // animator.SetTrigger("attaque");
            tempsEntreAttaque = debutAttaque;

            //instancier le projectile (attaqueArme)
            var projectile = Instantiate(attaqueArme, attaqueArme.transform.position, Quaternion.identity);

            projectile.GetComponent<toucherEnnemi>().AssocierJoueurAuProjectile(estUnJoueur);
            projectile.GetComponent<toucherEnnemi>().SetProjectile(true);

            //donner une vitesse au projectile
            var rbProjectile = projectile.GetComponent<Rigidbody>();

            rbProjectile.constraints = RigidbodyConstraints.None;

            rbProjectile.AddForce(transform.forward * 30, ForceMode.VelocityChange);

            //activer le collider du projectile ??? a continuer, ne fonctionne pas pour l'instant
           var coll = projectile.GetComponent<Collider>();
           coll.enabled = true;
            

            //détruire le projectile lorsqu'il touche un mur ou un ennemi

        }

    }
}
