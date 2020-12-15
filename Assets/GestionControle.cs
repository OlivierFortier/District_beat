using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class GestionControle : MonoBehaviour
{
   //Thomas Lorenzo

   //référence
    private  PlayerInput playerInput;
    private choisirPerso choisir;
    public GameObject scene;

    public bool pret;



    private void Awake(){

        // ont initialise les variables
        playerInput = GetComponent<PlayerInput>();
        var perso = FindObjectsOfType<choisirPerso>();
        var index = playerInput.playerIndex;
        // on détermine quel personage doit être controler par quel script
        choisir = perso.FirstOrDefault(m => m.GetPlayerIndex() == index);
           scene= GameObject.FindGameObjectWithTag("gestion");



    }




 public void Test(CallbackContext context){
  // on change de personnages
if(choisir != null)
choisir.Selection(context.ReadValue<float>());



 }

public void Pret(){

// on indique qu'on est pret 
  if(pret==false){
    scene.GetComponent<gestionscene>().Nbpret=scene.GetComponent<gestionscene>().Nbpret+1;
    pret=true;
    }


}



}
    