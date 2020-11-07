using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
