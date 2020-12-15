using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Olivier Fortier
public class GestionPret : MonoBehaviour
{

   
    // détruire le texte apres 5 secondes
    private void Start() => Destroy(this.gameObject, 5f);
}
