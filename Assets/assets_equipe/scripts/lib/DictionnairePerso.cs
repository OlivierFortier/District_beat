using System;
using UnityEngine;


/// <summary>
/// structure qui permet de créer un genre de dictionnaire reconnaissable par unity
/// puisque unity ne prends pas en charche les dictionnaires par défaut
/// </summary>
 [Serializable]
 public class DictionnairePerso<TypeCle, TypeValeur> {
     [SerializeField] public TypeCle objet;
    [SerializeField] public TypeValeur valeur;
 }
 