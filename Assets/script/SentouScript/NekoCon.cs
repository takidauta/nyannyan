using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekoCon : MonoBehaviour
{

    public static bool x = false;
    public void OnClick()
    {
        Debug.Log("ねこ出陣");
        x = true;
      
    }

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static bool getX()
    {
        return x;
    }
}
