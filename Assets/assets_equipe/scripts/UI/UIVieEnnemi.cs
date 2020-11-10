using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Olivier Fortier
// script de mise a jour du UI de barre de vie des ennemis
public class UIVieEnnemi : MonoBehaviour
{
    // référence à la barre de vie flottante de l'ennemi
    public GameObject barreVie;


    
    void Update()
    {
        // met constanement à jour le UI de vie
        barreVie.GetComponent<Image>().fillAmount = gameObject.GetComponent<healthBarController>().vie / gameObject.GetComponent<healthBarController>().vieDebut;
    
    }
}
