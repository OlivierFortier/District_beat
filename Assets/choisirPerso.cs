using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

    void Update() {
        if(SceneManager.GetActiveScene().name=="scene_jeu_principal"){

            var transformSalleDebut = GameObject.Find("salle-debut(Clone)").transform;

         if(IndexJoueur==0){
        gameObject.transform.localScale= new Vector3(1f,1f,1f);
        gameObject.transform.SetParent(transformSalleDebut);
         gameObject.transform.localPosition= new Vector3(9.05f,3.49f,8.22f);
        
         }
          if(IndexJoueur==1){
        gameObject.transform.localScale= new Vector3(1f,1f,1f);
        gameObject.transform.SetParent(transformSalleDebut);
         gameObject.transform.localPosition= new Vector3(-6.93f,3.49f,7.19f);
        
         }
          if(IndexJoueur==2){
        gameObject.transform.localScale= new Vector3(1f,1f,1f);
        gameObject.transform.SetParent(transformSalleDebut);
         gameObject.transform.localPosition= new Vector3(-6.93f,3.49f,20.75f);
        
         }
          if(IndexJoueur==3){
        gameObject.transform.localScale= new Vector3(1f,1f,1f);
        gameObject.transform.SetParent(transformSalleDebut);
         gameObject.transform.localPosition= new Vector3(9.12f,3.49f,20.75f);
        
         }

     
 }
 if(SceneManager.GetActiveScene().name=="fin_jeu"){
         
        Destroy(gameObject);
        

     
 }
 if(SceneManager.GetActiveScene().name=="Menu principal"){
         
        Destroy(gameObject);
        

     
 }
        
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
       DontDestroyOnLoad(gameObject);
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