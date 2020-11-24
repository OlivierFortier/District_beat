using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Alejandra Damaris Miranda Reyes & Olivier Fortier
// script qui gère le fonctionnement des barres de vie des entitées
public class healthBarController : MonoBehaviour
{
    // référence au prefab UI de barre de vie
    public GameObject refBarreDeVie;
    public Animator animator;
    // référence à l'instance invoquée du prefab de barre de vie
    private GameObject instanceBarreDeVie;
    // référence au UI de fond de barre de vie
    public GameObject fondBarreVie;
    public float vie;
    public float vieDebut;

    // état déterministe de la vie ou non-vie du personnage
  [HideInInspector]  public bool estMort = false;

    public float resistanceBase = 1f;

    public float resistanceActuelle;
    

    private void Start()
    {
        resistanceActuelle = resistanceBase;

        vie = vieDebut;

// si l'entitée possède un UI de barre de vie statique
        if (refBarreDeVie)
        {//on instancie le prefab
            instanceBarreDeVie = Instantiate(refBarreDeVie);

            //on parente au canvas l'élément UI
            instanceBarreDeVie.transform.SetParent(GameObject.Find("Canvas").transform);

            //on le positionne à la meme place que le fond
            instanceBarreDeVie.GetComponent<RectTransform>().anchoredPosition =
                fondBarreVie.GetComponent<RectTransform>().anchoredPosition;
        }
    }

// méthode qui permet à l'entitée de prendre des dommages et d'etre blessé
    public void PrendreDommages(float damage)
    {

        // la vie est calculée selon les résistances
        vie = vie - (damage / resistanceActuelle);

// si il y a un UI, mettre à jour le UI
        if (instanceBarreDeVie)
        {
            instanceBarreDeVie.GetComponent<Image>().fillAmount = vie / vieDebut;
        }

        //si le personnage est mort
        if (vie <= 0)
        {
            MortPersonnage();
        }
    }


    public void AugmenterResistance(float nouvelleResistance, float tempsBoost)
    {

        resistanceBase += nouvelleResistance;
        Invoke("RemettreResistanceNormale", tempsBoost);
    }

    public void RemettreResistanceNormale()
    {
        resistanceActuelle = resistanceBase;
    }

// méthode qui permet de reprendre de la vie
    public void PrendreMedecine(int medicament)
    {
        vie = vie + medicament;

        if (vie > vieDebut) vie = vieDebut;

        if (instanceBarreDeVie)
        {
            instanceBarreDeVie.GetComponent<Image>().fillAmount = vie / vieDebut;
        }
    }

// gestio nde la mort de l'entitée
    public void MortPersonnage()
    {

        estMort = true;

        if (animator)
        {
            animator.SetTrigger("mort");
        }

        // si c'est un ennemi, le détruire
        if (tag == "ennemi")
        {
            // dropper du loot
            Invoke("RelacherButin", 0.5f);
            Invoke("DetruirePersonnage", 2f);
        }
        // si c'est un joueur, terminer la partie
        else if (tag == "joueur")
        {
            Invoke("RelancerPartie", 4f);
        }

    }

    void DetruirePersonnage()
    {
        Destroy(this.gameObject);
    }

    void RelancerPartie()
    {
        SceneManager.LoadScene("fin_jeu");
    }

    // méthode pour déclencher le butin qui tombe de l'ennemi
    void RelacherButin() {
        TableButin controleButin = GetComponent<TableButin>();
        controleButin.TomberButin();
    }

}