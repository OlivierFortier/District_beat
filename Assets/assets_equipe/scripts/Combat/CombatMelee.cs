using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CombatMelee : MonoBehaviour
{
    public bool estUnJoueur;
    public float tempsEntreAttaque;
    public float debutAttaque;
    public Animator animator;
    public GameObject refAttaqueArme;

    [HideInInspector] public GameObject attaqueArme;
    public GameObject mainQuiPrendArme;

    private BoxCollider attaqueCollider;

    private void Start()
    {
        attaqueArme = Instantiate(refAttaqueArme, mainQuiPrendArme.transform);
        attaqueArme.GetComponent<toucherEnnemi>().AssocierJoueurAuProjectile(estUnJoueur);
        attaqueArme.transform.localPosition = new Vector3(0.03f, 0.14f, -0.07f);
        attaqueCollider = attaqueArme.GetComponent<BoxCollider>();
        attaqueCollider.enabled = false;
    }

    // Update is called once per frame
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
            Invoke("activerColliderArme", 1f);
            tempsEntreAttaque = debutAttaque;

            
        }

    }

    void activerColliderArme() {
        attaqueCollider.enabled = true;
        Invoke("desactiverColliderArme", 1f);
    }

    void desactiverColliderArme() {
        attaqueCollider.enabled = false;
    }
}
