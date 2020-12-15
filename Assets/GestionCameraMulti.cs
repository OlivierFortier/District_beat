using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GestionCameraMulti : MonoBehaviour
{

   public CinemachineTargetGroup groupeCamera;
//    private List<GameObject> lesJoueurs = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        var arrJoueurs = GameObject.FindGameObjectsWithTag("joueur");
        // Cinemachine.CinemachineTargetGroup.Target cible;

        foreach (GameObject joueur in arrJoueurs) {
            groupeCamera.AddMember(joueur.transform, 1f, 3.12f);
        }
    }

}
