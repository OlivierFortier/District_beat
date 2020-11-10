using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Bernard Dwyer
// script de gestion des boutons du menu principal
public class mainMenu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene(1);
    }
     public void Quitter()
    {     
        // yeet
       Debug.Log("QUIT!");
       Application.Quit();
       
    }  
}
