using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Olivier Fortier
// gestion de vie flottante UI des ennemis
public class VieFlottante : MonoBehaviour
{


// ou le UI doit etre placé
    public Transform cible;

// offset de déplacement si nécéssaire
    public Vector3 deplacement;

    private Camera cam;

   
    void Start()
    {
        cam = Camera.main;
    }

    
    void Update()
    {
        // trouver la position de la cible (ennemi)
        Vector3 pos = cam.WorldToScreenPoint(cible.position + deplacement);

    // mettre à jour la position du UI à la positio nde la cible
        if(transform.position != pos)
            transform.position = pos;
    }
}
