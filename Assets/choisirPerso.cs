﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class choisirPerso : MonoBehaviour
{
    [SerializeField]
    private int IndexJoueur =0;

    //Refference
    public MenuControle obj_MenuControle;

    private CharacterController controler;

    //les personages possible
    public GameObject Perso1; 
    public GameObject Perso2;
    public GameObject Perso3;
    public GameObject Perso4;

// personage actif pour faire ensuite les manipulation
    public GameObject actif;
    public GameObject[] Perso;


// numéro associer au personage
    public int numPerso;

    int val;


     private void Awake(){
         obj_MenuControle = new MenuControle();
        controler = GetComponent<CharacterController>();
        



    }

    public int GetPlayerIndex(){
        return IndexJoueur;
    }

    void Start(){
        Perso[0] = Perso1;
        Perso[1] = Perso1;
        Perso[2] = Perso2;
        Perso[3] = Perso2;
        Perso[4] = Perso3;
        Perso[5] = Perso3;
        Perso[6] = Perso4;
        Perso[7] = Perso4;
       
    }




    public void Selection(float num)
    {
        

          val= Mathf.FloorToInt(num) ;
            actif.SetActive(false);
            numPerso= numPerso+val;
            if(numPerso==8){
                numPerso=0;
            }
                if(numPerso==-2){
                numPerso=7;
            }

             actif = Perso[numPerso];
            Perso[numPerso].SetActive(true);

           
    }

    private void OnEnable(){
         obj_MenuControle.Enable();
    }

   
    private void OnDisable(){
        obj_MenuControle.Disable();
         
    }        
    
}