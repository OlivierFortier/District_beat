using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestionscene : MonoBehaviour


{

    public int Nbdjoueur;
    public int Nbpret;
    // Start is called before the first frame update
    void Start()
    { 
        Nbdjoueur=0;
        Nbpret=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Nbdjoueur!=0 && Nbdjoueur==Nbpret){

            Debug.Log("on passe");
        }
    
    }
}
