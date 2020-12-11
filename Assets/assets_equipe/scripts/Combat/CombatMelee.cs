using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

// Bernard Dwyer
// script qui permet a une entité d'attaquer au corps a corps
public class CombatMelee : MonoBehaviour
{
    // booléen pour savoir si c'est un joueur qui tient l'arme
    public bool estUnJoueur;
    public float tempsEntreAttaque;
    public float debutAttaque;

    public float dureeAttaque = 0.5f;
    public Animator animator;
    // référence au prefab de l'arme avec laquelle l'entité est équipée
    public GameObject refAttaqueArme;

// l'instance de l'arme invoquée par le prefab
      [HideInInspector] public GameObject attaqueArme;
    // référence au gameobject de la main qui tiens l'arme
    public GameObject mainQuiPrendArme;

    // référence au collider de l'arme
    private BoxCollider attaqueCollider;

    private void Start()
    {
        // instanciation et configuration de l'arme (position dans la main, désactiver le collider ,etc)
        attaqueArme = Instantiate(refAttaqueArme, mainQuiPrendArme.transform);
        attaqueArme.GetComponent<toucherEnnemi>().AssocierJoueurAuProjectile(estUnJoueur);
        attaqueArme.transform.localPosition = new Vector3(0.03f, 0.14f, -0.07f);
        attaqueCollider = attaqueArme.GetComponent<BoxCollider>();
        attaqueCollider.enabled = false;
    }


    void Update()
    {
        // gestion du délai entre les attaques
        if (tempsEntreAttaque > 0)
        {
            tempsEntreAttaque -= Time.deltaTime;
            
        }

    }

    public void Attaque()
    {
        // si on peut attaquer
        if (tempsEntreAttaque <= 0)
        {
            // attaquer
            animator.SetTrigger("attaque");
            ActiverColliderArme();
            tempsEntreAttaque = debutAttaque;

            
        }

    }

// actique le collider de l'arme pendant l'animation d'attaque
    void ActiverColliderArme() {
        attaqueCollider.enabled = true;
        Invoke("DesactiverColliderArme", dureeAttaque );
    }

    void DesactiverColliderArme() {
        attaqueCollider.enabled = false;
    }
}
