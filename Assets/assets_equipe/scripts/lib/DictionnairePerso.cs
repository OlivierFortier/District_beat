using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityObject = UnityEngine.Object;


 [Serializable]
 public struct DictionnairePerso<TypeCle, TypeValeur> {
     [SerializeField] public TypeCle objet;
    [SerializeField] public TypeValeur valeur;
 }
 }