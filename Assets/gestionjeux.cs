using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class gestionjeux : MonoBehaviour
{

    private  PlayerInput playerInput;
    private ControlleurJoueur choisir;


    



    private void Awake(){

        
        playerInput = GetComponent<PlayerInput>();
        var perso = FindObjectsOfType<ControlleurJoueur>();
        var index = playerInput.playerIndex;
        choisir = perso.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }




 public void Bouge(CallbackContext context){

if(choisir != null)
choisir.SetInputVector(context.ReadValue<Vector2>());



 }


 public void AttaqueM(){

if(choisir != null)
choisir.AttaqueMelee();



 }
  public void AttaqueD(){

if(choisir != null)
choisir.AttaqueDistance();



 }
  public void roule(){

if(choisir != null)
choisir.roulade();



 }



}
  