using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene(0);
    }
     public void Quitter()
    {     
       Debug.Log("QUIT!");
       Application.Quit();
       
    }  
}
