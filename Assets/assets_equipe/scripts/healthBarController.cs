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
        if (refHealthBar)
        {//on instancie le prefab
            instanceHealthBar = Instantiate(refHealthBar);

            //on parente au canvas l'élément UI
            instanceHealthBar.transform.SetParent(GameObject.Find("healthBar_Canvas").transform);

            //on le positionne à la meme place que le fond
            instanceHealthBar.GetComponent<RectTransform>().anchoredPosition =
                GameObject.Find("healthBar_BG").GetComponent<RectTransform>().anchoredPosition
            ;
        }

    }

    public void OnTakeDamage(float damage)
    {

        health = health - damage;

        if (refHealthBar)
        { instanceHealthBar.GetComponent<Image>().fillAmount = health / startHealth; }
    }

}