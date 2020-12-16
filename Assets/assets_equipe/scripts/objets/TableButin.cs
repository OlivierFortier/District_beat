using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Olivier Fortier
// script qui permet de gérer les chances qu'un ennemi possède de laisser tomber du butin lorsqu'il meurt
public class TableButin : MonoBehaviour
{

    // j'utilise ma structure de données perso qui est semblable a un dictionnaire de c#
    // le dictionnaire contiendra le butin, et le % de chance d'apparition du butin
    public List<DictionnairePerso<GameObject, float>> tableButin = new List<DictionnairePerso<GameObject, float>>();

// méthode pour faire tomber du butin aléatoirement
    public void TomberButin()
    {

        // choisir le butin selon les chances données
        GameObject butin;

        foreach (var dict in tableButin)
        {
            

            // si la chance aléatoire correspond à la chance associée à l'objet, instancier l'objet
            if (Random.Range(0, 100) <= dict.valeur)
            {

                butin = dict.objet;

                // faire apparaitre le butin par instanciation
                Instantiate(butin, transform.position, Quaternion.identity);
                
            }
        }



    }

}
