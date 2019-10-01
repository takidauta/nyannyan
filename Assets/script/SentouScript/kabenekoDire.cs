using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kabenekoDire : MonoBehaviour
{
    public GameObject kabenekoPre;
    bool kabeneko;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        kabeneko = kingakuCon.kabenekoDire;
        if (kabeneko==true)
        {
            GameObject go = Instantiate(kabenekoPre) as GameObject;
            go.name = kabenekoPre.name;
            go.transform.position = new Vector3(7f, -0.5f, 0);
            kingakuCon.kabenekoDire = false;
            
        }
    }
}
