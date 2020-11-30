using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Alejandra Damaris Miranda Reyes
//ce script permet de faire les boutons du jeu plus dynamiques en declanchant des sons selon les action du joueur
public class ButtonAnim : MonoBehaviour
{
   public AudioSource myFx;
   public AudioClip hoverFx;
   public AudioClip clickFx;

    //fonction qui permet de faire jouer un son lorsque le joueur passe la souris par dessus un objet,...dans ce cas, c'est un bouton
   public void HoverSound()
   {
       myFx.PlayOneShot(hoverFx);
   }
    //fonction qui permet de faire jouer un son lorsque le joueur appuie sur le button
   public void ClickSound()
   {
       myFx.PlayOneShot(clickFx);
   }
}
