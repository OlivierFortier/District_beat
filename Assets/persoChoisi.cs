using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persoChoisi : MonoBehaviour
{
// Thomas Lorenzo

   // on déclare les valeur qui vont accueillir les personnages joueurs
    public int J1;
    public int J2;
    public int J3;
    public int J4;

    public GameObject Perso1; 
    public GameObject Perso2;
    public GameObject Perso3;
    public GameObject Perso4;

    
    // Start is called before the first frame update
    void Start()
    {
                   DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        // on regarde premièrement si le joueur a rejoint 
        if (Perso1.activeSelf ==true)
        {   // on assigne la valeur du numéro du personnage, on l'utilisera ensuite pour mettre le personnage dans la scène de jeux
            J1 = Perso1.GetComponent<choisirPerso>().numPerso;
            
        }
        else{// on assigne une valeur qu'on es sur qui ne sera jamais sélectionner
            J1=20;
        }
        if (Perso2.activeSelf ==true)
        {
            J2 = Perso2.GetComponent<choisirPerso>().numPerso;
            
        }
          else{
            J2=20;
        }
        if (Perso3.activeSelf ==true)
        {
            J3 = Perso3.GetComponent<choisirPerso>().numPerso;
            
        }
          else{
            J3=20;
        }
        if (Perso4.activeSelf ==true)
        {
            J4 = Perso4.GetComponent<choisirPerso>().numPerso;
            
        }
          else{
            J4=20;
        }

        
    }
}
