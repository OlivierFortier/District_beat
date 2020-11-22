using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonfx : MonoBehaviour
{
   public AudioSource myFx;
   public AUdioClip hoverFx;
   public AUdioClip clickFx;

   public void HoverSound()
   {
       myFx.PlayOneShot(hoverFx);
   }
   public void ClickSound()
   {
       myFx.PlayOneShot(clickFx);
   }
}
