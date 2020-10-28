using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBarController : MonoBehaviour
{
    public GameObject refHealthBar;
    public Animator animator;
    private GameObject instanceHealthBar;
    public float health;
    public float startHealth;

    private void Start()
    {
        if (refHealthBar)
        {//on instancie le prefab
            instanceHealthBar = Instantiate(refHealthBar);

            //on parente au canvas l'élément UI
            instanceHealthBar.transform.SetParent(GameObject.Find("Canvas").transform);

            //on le positionne à la meme place que le fond
            instanceHealthBar.GetComponent<RectTransform>().anchoredPosition =
                GameObject.Find("healthBar_BG").GetComponent<RectTransform>().anchoredPosition;

        }

    }

    public void OnTakeDamage(float damage)
    {
        health = health - damage;

        if (instanceHealthBar)
        {
            instanceHealthBar.GetComponent<Image>().fillAmount = health / startHealth;
        }

        //si le personnage est mort
        if (health <= 0)
        {
            mortPersonnage();
        }
    }

    public void OnTakeMedicine(int medicament)
    {
        health = health + medicament;

        if (instanceHealthBar)
        {
            instanceHealthBar.GetComponent<Image>().fillAmount = health / startHealth;
        }

    }

    public void mortPersonnage()
    {

        if (animator)
        {
            animator.SetTrigger("mort");
        }

        if (tag == "ennemi")
        {
            Invoke("detruirePersonnage", 2f);
        }
        else if (tag == "joueur")
        {
            Invoke("relancerPartie", 4f);
        }

    }

    void detruirePersonnage()
    {
        Destroy(this.gameObject);
    }

    void relancerPartie()
    {
        SceneManager.LoadScene(1);
    }

}