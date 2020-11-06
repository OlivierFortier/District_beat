using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBarController : MonoBehaviour
{
    public GameObject refBarreDeVie;
    public Animator animator;
    private GameObject instanceBarreDeVie;
    public GameObject fondBarreVie;
    public float vie;
    public float vieDebut;

    public float resistanceBase = 1f;

    public float resistanceActuelle;

    private void Start()
    {
        resistanceActuelle = resistanceBase;

        vie = vieDebut;

        if (refBarreDeVie)
        {//on instancie le prefab
            instanceBarreDeVie = Instantiate(refBarreDeVie);

            //on parente au canvas l'élément UI
            instanceBarreDeVie.transform.SetParent(GameObject.Find("Canvas").transform);

            //on le positionne à la meme place que le fond
            instanceBarreDeVie.GetComponent<RectTransform>().anchoredPosition =
                fondBarreVie.GetComponent<RectTransform>().anchoredPosition;
        }
    }

    public void PrendreDommages(float damage)
    {
        print("allo");
        print(damage);
        vie = vie - (damage / resistanceActuelle);

        if (instanceBarreDeVie)
        {
            instanceBarreDeVie.GetComponent<Image>().fillAmount = vie / vieDebut;
        }

        //si le personnage est mort
        if (vie <= 0)
        {
            MortPersonnage();
        }
    }

    public void AugmenterResistance(float nouvelleResistance, float tempsBoost)
    {

        resistanceBase += nouvelleResistance;
        Invoke("RemettreResistanceNormale", tempsBoost);
    }

    public void RemettreResistanceNormale()
    {
        resistanceActuelle = resistanceBase;
    }

    public void PrendreMedecine(int medicament)
    {
        vie = vie + medicament;

        if (vie > vieDebut) vie = vieDebut;

        if (instanceBarreDeVie)
        {
            instanceBarreDeVie.GetComponent<Image>().fillAmount = vie / vieDebut;
        }
    }

    public void MortPersonnage()
    {

        if (animator)
        {
            animator.SetTrigger("mort");
        }

        if (tag == "ennemi")
        {
            Invoke("DetruirePersonnage", 2f);
        }
        else if (tag == "joueur")
        {
            Invoke("RelancerPartie", 4f);
        }

    }

    void DetruirePersonnage()
    {
        Destroy(this.gameObject);
    }

    void RelancerPartie()
    {
        SceneManager.LoadScene(1);
    }

}