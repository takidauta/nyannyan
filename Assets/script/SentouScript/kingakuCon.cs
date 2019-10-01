using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kingakuCon : MonoBehaviour
{
    
    GameObject kingakuText;
    float kingaku;//現在の金額
    int saidai;//金額の最大値

    int neko;//ねこの値段
    bool f;//ねこスクリプトの値をこいつに代入

    int kabenedan;//かべねこの値段
    bool kabe;//かべねこの値段をこいつに代入
    public static bool kabenekoDire=false;
   
    int jyougen; //上限解放
    int kaisuu;//上限解放の数をここで決める
    bool j;//解放スクリプトの値をこいつに代入




    // Start is called before the first frame update
    void Start()
    {
        this.kingakuText = GameObject.Find("KingakuText");
        kingaku = 0;//金額を0から始める
        saidai = 2000;//金額の最大値はここで変更
        neko = 75;　　　//ねこ値段はここで変更
        kabenedan = 150;//壁猫の値段はここで変更
        jyougen = 500;//上限解放はここで変更
        kaisuu = 0;//上限解放の回数をここで変更
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        f = NekoCon.x;　　//ねこボタンを押したときのコード
        kabe = KabenekoButtonCon.kabeneko;//かべねこボタンを押したときのコード

        j = KaihouCon.kaihou;

        //かべねこの金額の骨組みと出撃
        if (kabe == true&&kabenedan<=kingaku)
        {
            kabenekoDire = true;
            

            Debug.Log("かべねこ出陣");
            kingaku -= kabenedan;
            KabenekoButtonCon.kabeneko = false;
        }

        

        //ねこの金額骨組み
        if (f == true && neko <= kingaku)
        {
            Debug.Log("ねこ出陣");
            kingaku -= neko;
            NekoCon.x = false;
        }

        //上限解放骨組み
        if (j == true&&kaisuu<7)
        {
            Debug.Log("上限解放");
            saidai += jyougen;
            KaihouCon.kaihou = false;
            kaisuu += 1;
            
        }


        //金額の骨組み
        if (kingaku<saidai-0.1f)//金額の最大値がsaidaiの値
        kingaku += Time.deltaTime*100;//1秒間に100円ずつ増える
        this.kingakuText.GetComponent<Text>().text = ((int)kingaku)+"/"+saidai+"円";//現在の金額と最大値の金額をTextに表示
    }
    public static bool getkabenekoDire()
    {
        return kabenekoDire;
    }
}
