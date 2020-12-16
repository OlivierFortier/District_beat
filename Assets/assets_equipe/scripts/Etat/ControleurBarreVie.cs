using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Alejandra Damaris Miranda Reyes & Olivier Fortier
// script qui gère le fonctionnement des barres de vie des entitées
public class ControleurBarreVie : MonoBehaviour
{
    // référence au prefab UI de barre de vie
    public GameObject refBarreDeVie;
    public Animator animator;
    // référence à l'instance invoquée du prefab de barre de vie
    private GameObject instanceBarreDeVie;
    // référence au UI de fond de barre de vie
    public GameObject fondBarreVie;

    // vie actuelle du personnage
    public float vie;

    // vie de départ du personnage( vie maximale)
    public float vieDebut;

    // état déterministe de la vie ou non-vie du personnage
  [HideInInspector]  public bool estMort = false;

// résistance de départ du personnage
    public float resistanceBase = 1f;

// résistance pendant le jeu du personnage
    public float resistanceActuelle;
    


    private void Start()
    {
        // ajuster les résistances et la vie
        resistanceActuelle = resistanceBase;

        vie = vieDebut;
        

// si l'entitée possède un UI de barre de vie statique
        if (refBarreDeVie)
        {//on instancie le prefab
            instanceBarreDeVie = Instantiate(refBarreDeVie);

            //on parente au canvas l'élément UI
            instanceBarreDeVie.transform.SetParent(GameObject.Find("Canvas").transform.Find("groupe-arrangement").transform);

          
        }
    }

// méthode qui permet à l'entitée de prendre des dommages et d'etre blessé  Olivier  & Alejandra
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


// méthode permettant d'augmenter les résistances d'un personnage pendant un temps donné  Olivier Fortier
    public void AugmenterResistance(float nouvelleResistance, float tempsBoost)
    {

        resistanceActuelle += nouvelleResistance;
        Invoke("RemettreResistanceNormale", tempsBoost);
    }

    // méthode pour remettre la résistance a son état normal   Olivier Fortier

    public void RemettreResistanceNormale()
    {
        resistanceActuelle = resistanceBase;
    }

// méthode qui permet de reprendre de la vie   Olivier Fortier
    public void PrendreMedecine(int medicament)
    {
        vie = vie + medicament;

        if (vie > vieDebut) vie = vieDebut;

        if (instanceBarreDeVie)
        {
            instanceBarreDeVie.GetComponent<Image>().fillAmount = vie / vieDebut;
        }
    }

// gestion de la mort de l'entitée  Olivier Fortier
    public void MortPersonnage()
    {

        estMort = true;

        animator.SetTrigger("mort");
        

        // si c'est un ennemi, le détruire
        if (tag == "ennemi")
        {
            // dropper du loot
            Invoke("RelacherButin", 0.5f);
            Invoke("DetruirePersonnage", 3f);
        }
        // si c'est un joueur, terminer la partie
        else if (tag == "joueur")
        {
            //supprimer le gameobject du joueur apres 1 seconde
            ControlleurJoueur.nombreJoueursMort += 1;
            print("bonsoir");
            Destroy(this.gameObject, 1f);
        }

    }

    // méthode pour ôter l'existence de l'objet  Olivier Fortier

    void DetruirePersonnage()
    {
        Destroy(this.gameObject);
    }


    // méthode pour déclencher le butin qui tombe de l'ennemi   Olivier Fortier
    void RelacherButin() {
        TableButin controleButin = GetComponent<TableButin>();
        controleButin.TomberButin();
    }

}