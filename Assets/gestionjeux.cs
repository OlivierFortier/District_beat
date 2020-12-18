using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class gestionjeux : MonoBehaviour
{
   //Thomas Lorenzo

      //référence
    private  PlayerInput playerInput;
    private ControlleurJoueur choisir;
    private ControleurBarreVie choisirvie;

    



    private void Awake(){

      // ont initialise les variables 
      // on détermine quel personage doit être controler par quel script
        playerInput = GetComponent<PlayerInput>();
        var perso = FindObjectsOfType<ControlleurJoueur>();

                var index = playerInput.playerIndex;
                choisir = perso.FirstOrDefault(m => m.GetPlayerIndex() == index);



    }




 public void Bouge(CallbackContext context){
// on envoie une valeurs a un autre script pour pouvoir faire bouger le perso
if(choisir != null)
choisir.SetInputVector(context.ReadValue<Vector2>());



 }


 public void AttaqueM(){
// on envoie une valeurs a un autre script pour pouvoir faire attaquer le perso
if(choisir != null)
choisir.AttaqueMelee();



 }
  public void AttaqueD(){
// on envoie une valeurs a un autre script pour pouvoir faire attaquer le perso
if(choisir != null)
choisir.AttaqueDistance();



 }
  public void roule(){
// on envoie une valeurs a un autre script pour pouvoir faire rouler le perso
if(choisir != null)
choisir.roulade();



 }


  public void Cheater(){
// on envoie une valeurs a un autre script pour pouvoir tricher et finir le jeux sans mourir
if(choisir != null)
choisir.triche();



 }



}
  