using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
public class joindreJeux : MonoBehaviour
{

   //Thomas Lorenzo
     public GameObject[] Joueurs;
     public GameObject[] MessageJoueurs;
     public GameObject scene;


    public int Nbjoueur;



public void Joindre(){

// gère le login des joueurs
MessageJoueurs[Nbjoueur].SetActive(false);
Joueurs[Nbjoueur].SetActive(true);
scene.GetComponent<gestionscene>().Nbdjoueur=scene.GetComponent<gestionscene>().Nbdjoueur+1;
Nbjoueur=Nbjoueur+1;



}
}
