using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class GestionControle : MonoBehaviour
{

    private  PlayerInput playerInput;
    private choisirPerso choisir;
    public GameObject scene;

    public bool pret;



    private void Awake(){

        
        playerInput = GetComponent<PlayerInput>();
        var perso = FindObjectsOfType<choisirPerso>();
        var index = playerInput.playerIndex;
        choisir = perso.FirstOrDefault(m => m.GetPlayerIndex() == index);
           scene= GameObject.FindGameObjectWithTag("gestion");

    }




 public void Test(CallbackContext context){

if(choisir != null)
choisir.Selection(context.ReadValue<float>());



 }

public void Pret(){


  if(pret==false){
    scene.GetComponent<gestionscene>().Nbpret=scene.GetComponent<gestionscene>().Nbpret+1;
    pret=true;
    }


}



}
    