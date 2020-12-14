using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("principal").transform);
         gameObject.transform.localPosition= new Vector3(0f,0f,0f);
        
         
        
    }

    // Update is called once per frame

}
