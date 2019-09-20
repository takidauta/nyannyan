using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaihouCon : MonoBehaviour
{
    public static bool kaihou=false;//bool型の変数kaihouをゲーム全体で管理
    public void OnClick()
    {
        kaihou = true;
        Debug.Log("上限開放");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static bool getKaihou()//kaihouの戻り値などを設定
    {
        return kaihou;
    }
}
