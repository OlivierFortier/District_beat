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

    private void Awake(){


        playerInput = GetComponent<PlayerInput>();
        var perso = FindObjectsOfType<choisirPerso>();
        var index = playerInput.playerIndex;
        choisir = perso.FirstOrDefault(m => m.GetPlayerIndex() == index);

    }


 public void Test(CallbackContext context){

if(choisir != null)
choisir.Selection(context.ReadValue<float>());

 }

}
