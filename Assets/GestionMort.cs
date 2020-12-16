using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Olivier Fortier
// script qui gère la mort des joueurs en multijoueur
public class GestionMort : MonoBehaviour
{
    
    // trouver le nombre de joueurs actifs
    void Start() { ControlleurJoueur.nombreJoueurs = GameObject.FindGameObjectsWithTag("joueur").Length;
     }


    void Update()
    {
       
        //si tous les joueurs sont morts, relancer la partie
        if(ControlleurJoueur.nombreJoueursMort >= ControlleurJoueur.nombreJoueurs) {
            RelancerPartie();
        }
        
    }


    // Méthode qui permet de relancer la partie
    void RelancerPartie()
    {
        ControlleurJoueur.nombreJoueursMort = 0;
        SceneManager.LoadScene("fin_jeu");
    }
}
