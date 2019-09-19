using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kingakuCon : MonoBehaviour
{
    GameObject kingakuText;
    float a;//現在の金額
    int saidai;//金額の最大値

    // Start is called before the first frame update
    void Start()
    {
        this.kingakuText = GameObject.Find("KingakuText");
        a = 0;
        saidai = 2000;//金額の最大値はここで変更
    }

    // Update is called once per frame
    void Update()
    {
        if(a<saidai)//金額の最大値がsaidaiの値
        a += Time.deltaTime*100;//1秒間に100円ずつ増える
        this.kingakuText.GetComponent<Text>().text = a.ToString("F2")+"/"+saidai;
    }
}
