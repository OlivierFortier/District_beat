using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIVieEnnemi : MonoBehaviour
{
    public GameObject barreVie;


    // Update is called once per frame
    void Update()
    {
        barreVie.GetComponent<Image>().fillAmount = gameObject.GetComponent<healthBarController>().vie / gameObject.GetComponent<healthBarController>().vieDebut;
    
    }
}
