﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButtonCon : MonoBehaviour
{

    public GameObject Bgm;
    public void OnClick()
    {
      
        FadeManager.Instance.LoadScene("nekokitiScene", 0.5f);
        
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
