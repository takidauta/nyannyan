using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtoCon : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        SceneManager.LoadScene("titleScene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
