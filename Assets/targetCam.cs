using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetCam : MonoBehaviour
{

    //Thomas Lorenzo
    // Start is called before the first frame update
    void Start()
    {
        // on positionne la camera
        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("principal").transform);
         gameObject.transform.localPosition= new Vector3(0f,0f,0f);
        
         
        
    }

    // Update is called once per frame

}
