using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Olivier Fortier
// gestion de la section de fin. Si le joueur entre dans cette section , la partie se termine
public class FinNiveau : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision) {
        
        if(collision.gameObject.CompareTag("joueur")) {
            SceneManager.LoadScene("fin_jeu");
        }

    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("joueur")) {
            SceneManager.LoadScene("fin_jeu");
        }
    }
}
