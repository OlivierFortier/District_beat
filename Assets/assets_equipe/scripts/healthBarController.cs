using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarController : MonoBehaviour
{
    public GameObject refHealthBar;
    private GameObject instanceHealthBar;
    public float health;
    public float startHealth;

    private void Start()
    {
        //on instancie le prefab
        instanceHealthBar = Instantiate(refHealthBar);

        //on parente au canvas l'élément UI
        instanceHealthBar.transform.SetParent(GameObject.Find("healthBar_Canvas").transform);//????

        //on le positionne à la meme place que le fond
        instanceHealthBar.GetComponent<RectTransform>().anchoredPosition =
            GameObject.Find("healthBar_BG").GetComponent<RectTransform>().anchoredPosition
        ;
    }

    public void OnTakeDamage(int damage)
    {
        health = health - damage;
        instanceHealthBar.GetComponent<Image>().fillAmount = health / startHealth;
    }


    public void OnTakeMedicine(int medicament)
    {
        health = health + medicament;
        instanceHealthBar.GetComponent<Image>().fillAmount = health / startHealth;
    }

    public void OnDie(int die)
    {
        health = health - die;
        instanceHealthBar.GetComponent<Image>().fillAmount = health / startHealth;
    }
}