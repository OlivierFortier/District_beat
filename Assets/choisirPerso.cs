using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class choisirPerso : MonoBehaviour
{
    //Thomas Lorenzo

    // le numéro associer au personage joueur
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

     public bool fini;


     private void Awake(){

         //on initialise les variables
         obj_MenuControle = new MenuControle();
        controler = GetComponent<CharacterController>();




    }
    public void fait(){
        fini=true;
    }
    void Update() {
        if(SceneManager.GetActiveScene().name=="scene_jeu_principal"){
            // on définie la variable 
            var transformSalleDebut = GameObject.Find("salle-debut(Clone)").transform;


            if(fini==false){

        GameObject joueur1;
        GameObject joueur2;
        GameObject joueur3;
        GameObject joueur4;
        // on va chercher le perso 1
        joueur1 = gameObject.transform.GetChild(0).gameObject;
        // et on force sa position
        joueur1.transform.localPosition =new Vector3(0f,0f,0);
        // on va chercher le perso 2
        joueur2 = gameObject.transform.GetChild(1).gameObject;
        // et on force sa position
        joueur2.transform.localPosition =new Vector3(0f,0f,0);
        
        // on va chercher le perso 3
        joueur3 = gameObject.transform.GetChild(2).gameObject;
        // et on force sa position
        joueur3.transform.localPosition =new Vector3(0f,0f,0);
        // on va chercher le perso 4
        joueur4 = gameObject.transform.GetChild(3).gameObject;
        // et on force sa position
        joueur4.transform.localPosition =new Vector3(0f,0f,0);
        Invoke("fait", 1f);

        }
         if(IndexJoueur==0){
        // on change les paramêtre transform du joueur 
        gameObject.transform.localScale= new Vector3(1f,1f,1f);
        gameObject.transform.SetParent(transformSalleDebut);
         gameObject.transform.localPosition= new Vector3(4,4.56f,8.22f);
        
        
         }
          if(IndexJoueur==1){
        // on change les paramêtre transform du joueur 
        gameObject.transform.localScale= new Vector3(1f,1f,1f);
        gameObject.transform.SetParent(transformSalleDebut);
         gameObject.transform.localPosition= new Vector3(-6.93f,4.56f,12.19f);
        
         }
          if(IndexJoueur==2){
        // on change les paramêtre transform du joueur
        gameObject.transform.localScale= new Vector3(1f,1f,1f);
        gameObject.transform.SetParent(transformSalleDebut);
         gameObject.transform.localPosition= new Vector3(-6.93f,4.56f,4.22f);
        
         }
          if(IndexJoueur==3){
        // on change les paramêtre transform du joueur
        gameObject.transform.localScale= new Vector3(1f,1f,1f);
        gameObject.transform.SetParent(transformSalleDebut);
         gameObject.transform.localPosition= new Vector3(9.12f,4.56f,4.22f);
        
         }

     
 }
 if(SceneManager.GetActiveScene().name=="fin_jeu"){
        // on détruit l'objet si il n'est pas dans la scène voulu
        Destroy(gameObject);
        

     
 }
 if(SceneManager.GetActiveScene().name=="Menu principal"){
        // on détruit l'objet si il n'est pas dans la scène voulu
        Destroy(gameObject);
        

     
 }
        
    }

    public int GetPlayerIndex(){
        // on cherche l'index du joueur
        return IndexJoueur;
    }

    void Start(){

        //on initialise les variables
        Perso[0] = Perso1;
        Perso[1] = Perso1;
        Perso[2] = Perso2;
        Perso[3] = Perso2;
        Perso[4] = Perso3;
        Perso[5] = Perso3;
        Perso[6] = Perso4;
        Perso[7] = Perso4;
       DontDestroyOnLoad(gameObject);
               fini= false; 
    }




    public void Selection(float num)
    {   

        // on tourne dans une roue de personage
        

          val= Mathf.FloorToInt(num) ;
            actif.SetActive(false);
            numPerso= numPerso+val;
            // on s'assure que rien de dépase du array
            if(numPerso==8){
                
                numPerso=0;
            }
                if(numPerso==-2){
                numPerso=6;
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