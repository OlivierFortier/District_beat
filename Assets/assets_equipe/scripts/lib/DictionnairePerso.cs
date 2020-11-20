using System;
using UnityEngine;


 [Serializable]
 public struct DictionnairePerso<TypeCle, TypeValeur> {
     [SerializeField] public TypeCle objet;
    [SerializeField] public TypeValeur valeur;
 }
 