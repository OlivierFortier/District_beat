using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

// Olivier Fortier
// script qui permet a une entitée d'attaquer a distance
public class CombatDistance : MonoBehaviour
{
    // booléen pour savoir si c'est un joueur qui tient l'arme
    public bool estUnJoueur = false;
    public float tempsEntreAttaque;
    public float debutAttaque;
    public Animator animator;
    // référence au prefab de l'arme avec laquelle l'entité est équipée
    public GameObject refAttaqueArme;

    // l'instance de l'arme invoquée par le prefab
    [HideInInspector] public GameObject attaqueArme;
    // référence au gameobject de la main qui tiens l'arme
    public GameObject mainQuiPrendArme;

    private void Start()
    {
        // on instancie l'arme dans la main du personnage
        attaqueArme = Instantiate(refAttaqueArme, mainQuiPrendArme.transform);

        // on associe l'entitée au projectile selon la variable booléenne
        attaqueArme.GetComponent<toucherEnnemi>().AssocierJoueurAuProjectile(estUnJoueur);

        // on ajuste la position de l'arme dans la main
        attaqueArme.transform.localPosition = new Vector3(0.03f, 0.14f, -0.07f);

        Invoke("DesactiverScript", 0.5f);
    }

    void DesactiverScript() { enabled = false; }

    void Update()
    {
        // décompte du délai entre les attaques
        if (tempsEntreAttaque > 0)
        {
            tempsEntreAttaque -= Time.deltaTime;

        }

    }

    // méthode de gestion de l'attaque
    public void Attaque()
    {
        // si on peut attaquer
        if (tempsEntreAttaque <= 0)
        {
            // activer l'animator et remettre le décompte entre les attaques
            animator.SetTrigger("lance");
            tempsEntreAttaque = debutAttaque;

            //instancier le projectile 
            var projectile = Instantiate(attaqueArme, attaqueArme.transform.position, Quaternion.identity);

            // configurer le projectile
            projectile.GetComponent<toucherEnnemi>().AssocierJoueurAuProjectile(estUnJoueur);
            projectile.GetComponent<toucherEnnemi>().SetProjectile(true);

            // obtenir les références au rigidbody du projectile
            var rbProjectile = projectile.GetComponent<Rigidbody>();

            // ôter les contrainte qui empeche le rigidbody de bouger dans l'espace
            rbProjectile.constraints = RigidbodyConstraints.None;

            // propulser le projectile
            rbProjectile.AddForce(transform.forward * 30, ForceMode.VelocityChange);

            //activer le collider du projectile 
            var coll = projectile.GetComponent<Collider>();
            coll.enabled = true;

        }

    }
}
