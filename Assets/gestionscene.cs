using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestionscene : MonoBehaviour


{
   //Thomas Lorenzo

   // le nombre de joueur présent dans le jeux
    public int Nbdjoueur;

    // le nombre de joueur prèt
    public int Nbpret;

    // la prochaine scene à charger
    private int prochaineScene;
    // Start is called before the first frame update
    void Start()
    {  
        //on initialise les variables
        prochaineScene = SceneManager.GetActiveScene().buildIndex +1;
        Nbdjoueur=0;
        Nbpret=0;
        
    }



    // Update is called once per frame
    void Update()
    { // si le nombre de joueur n'est pas égale a 0 
    //et qu'il est égale au nombre de joueur prèt  alors change de scene
        if(Nbdjoueur!=0 && Nbdjoueur==Nbpret){

           SceneManager.LoadScene(prochaineScene);
        }
    
    }
}
