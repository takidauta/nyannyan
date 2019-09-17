using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMcon : MonoBehaviour
{ 


    public bool DontDestory=true;

    public static Sound instance = null;
    
    public static Sound Instance
    {
        get { return instance; }
    }

     void Awake()
    {
       if(instance != null &&instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestoryOnLoad(this.gameObject);
    }

    public GameObject nyakoBGM;

    // Start is called before the first frame update
    void Start()
    {
        if (DontDestory)
        {
            DontDestroyOnLoad(nyakoBGM);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    
}
