using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Bernard Dwyer et Alejandra Miranda
// script de gestion des boutons du menu principal
public class mainMenu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene("Scene_jeu_principal");
    }
    public void choixJoueur()
    {
        SceneManager.LoadScene("Choix perso");
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void accueil()
    {
        SceneManager.LoadScene("Menu principal");
    }
    public void Quitter()
    {     
        // yeet
       Debug.Log("QUIT!");
       Application.Quit();
       
    }  
}
