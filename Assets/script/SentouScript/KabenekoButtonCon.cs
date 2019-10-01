using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabenekoButtonCon : MonoBehaviour
{
    public static bool kabeneko=false;
    public void OnClick()
    {
        Debug.Log("かべねこ出陣");
        kabeneko = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static bool getKabeneko()
    {
        return kabeneko;
    }
}
