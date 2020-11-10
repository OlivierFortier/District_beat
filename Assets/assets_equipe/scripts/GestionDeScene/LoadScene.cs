using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

// Alejandra Damaris Miranda Reyes
// script de changement de scene
public class LoadScene : MonoBehaviour
{
 public void SceneLoader(int SceneIndex)
 {
    SceneManager.LoadScene(SceneIndex);
 }
}