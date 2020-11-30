using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
public class joindreJeux : MonoBehaviour
{


     public GameObject[] Joueurs;
     public GameObject[] MessageJoueurs;
     public GameObject scene;


    public int Nbjoueur;
    public int i;



public void Joindre(){
Nbjoueur=Nbjoueur+i;

MessageJoueurs[Nbjoueur].SetActive(false);
Joueurs[Nbjoueur].SetActive(true);
scene.GetComponent<gestionscene>().Nbdjoueur=scene.GetComponent<gestionscene>().Nbdjoueur+1;

i=i+1;


}
}
