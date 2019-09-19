using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kingakucon : MonoBehaviour
{
    GameObject kingakuText;
    float kingaku = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.kingakuText = GameObject.Find("kingakuText");
    }

    // Update is called once per frame
    void Update()
    {
        if(kingaku<2000)
        kingaku+=Time.deltaTime*100;

        this.kingakuText.GetComponent<Text>().text = ((int)kingaku).ToString() + "/" + "2000";

    }
}
