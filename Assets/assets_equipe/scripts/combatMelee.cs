using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class combatMelee : MonoBehaviour
{
    public float tempsEntreAttaque;
    public float debutAttaque;
    public Animator animator;
    public BoxCollider attaqueCollider;

    private void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (tempsEntreAttaque <= 0)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                attaque();
                tempsEntreAttaque = debutAttaque;
            }
        }
        else
        {
            tempsEntreAttaque -= Time.deltaTime;
            animator.SetBool("attaque", false);
            attaqueCollider.enabled = false;
        }

    }

    void attaque()
    {
        animator.SetBool("attaque", true);
        attaqueCollider.enabled = true;
        Debug.Log("pow");
    }
}
