using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

// Olivier Fortier
// script qui gère l'apparition aléatoire des ennemis dans une salle.
public class ControlleurApparition : MonoBehaviour
{
    // liste des points d'apparitions possibles. Ce sont les enfants de ce gameobject (capsules jaunes)
    List<GameObject> listePointsApparition = new List<GameObject>();

    // Liste des objets prefab qu'on veut instancier aléatoirement
    public List<GameObject> listeObjetsAInstancier = new List<GameObject>();
    
    // désactiver l'objet au chargement, pour ne pas surcharger le jeu de 500 ennemis
    void Awake() => enabled = false;

    void Start()
    {
        // remplir la liste des points
        foreach (Transform point in transform)
        {
            listePointsApparition.Add(point.gameObject);
            // enlever le renderer des points d'apparitions
            point.gameObject.GetComponentInChildren<Renderer>().enabled = false;
        }

        

    }

   
    void Update()
    {
        // tant qu'il reste des prefabs à instancier, on exécute la fonction pour les instancier
        while (listeObjetsAInstancier.Count > 0)
        {
            InstancierObjet();
        }
        
    }

// Méthode pour instancier un prefab sur un point parmis la liste des points
    void InstancierObjet() {
        //obtention d'une position parmis les points placés
        GameObject positionParmisLesPoints = listePointsApparition.ObtenirEtEnlever<GameObject>(Random.Range(0, listePointsApparition.Count - 1));
        //obtention d'un objet aléatoire parmis la liste donnée dans unity
        GameObject prefabAleatoire = listeObjetsAInstancier.ObtenirEtEnlever<GameObject>(Random.Range(0, listeObjetsAInstancier.Count - 1));

        //instancier l'objet a la position du point obtenu
        Instantiate(prefabAleatoire, positionParmisLesPoints.transform.position, Quaternion.identity);
    }
}
