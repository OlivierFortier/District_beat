using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CombatMelee : MonoBehaviour
{
    public float tempsEntreAttaque;
    public float debutAttaque;
    public Animator animator;
    public GameObject refAttaqueArme;
    private GameObject attaqueArme;
    public GameObject mainQuiPrendArme;

    private BoxCollider attaqueCollider;

    private void Start()
    {
        attaqueArme = Instantiate(refAttaqueArme, mainQuiPrendArme.transform);
        attaqueArme.transform.localPosition = new Vector3(0.03f, 0.14f, -0.07f);
        attaqueCollider = attaqueArme.GetComponentInChildren<BoxCollider>();
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
            attaqueCollider.enabled = true;
            tempsEntreAttaque = debutAttaque;

            Invoke("desactiverColliderArme", 1.5f);
        }

    }

    void desactiverColliderArme() {
        attaqueCollider.enabled = false;
    }
}
