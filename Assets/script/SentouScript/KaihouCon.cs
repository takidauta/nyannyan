using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaihouCon : MonoBehaviour
{
    public static bool kaihou=false;
    public void OnClick()
    {
        Debug.Log("上限解放");
        kaihou = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static bool getKaihou()
    {
        return kaihou;
    }
}
