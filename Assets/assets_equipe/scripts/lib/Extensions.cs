using System.Collections;
using System.Collections.Generic;

// Olivier Fortier
// classe statique pour créer des méthodes extensions de différents interfaces, type, structs, classes, etc
public static class Extensions
{
    // méthode d'extension qui permet d'enlever un item spécifique de la liste, et de le retourner en même temps
    public static leType ObtenirEtEnlever<leType>(this IList<leType> liste, int indexAEnlever)
    {
        // lock permet d'empecher certaines erreurs si un autre script tente de modifier la liste en meme temps
        lock(liste)
        {
            // leType est un générique, ca permet de spécifier le type de l'objet recu lorsqu'on apelle la méthode. ex : GameObject
            leType objet = liste[indexAEnlever];
            liste.RemoveAt(indexAEnlever);
            return objet;
        }
    }
}