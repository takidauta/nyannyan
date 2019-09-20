using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kingakuCon : MonoBehaviour
{
    GameObject kingakuText;
    float kingaku;//現在の金額
    int saidai;//金額の最大値
    bool f;
    int neko;//ねこの値段


    // Start is called before the first frame update
    void Start()
    {
        this.kingakuText = GameObject.Find("KingakuText");
        kingaku = 0;//金額を0から始める
        saidai = 2000;//金額の最大値はここで変更
        neko = 75;　　　//ねこ値段はここで変更
    }

    // Update is called once per frame
    void Update()
    {

        f = NekoCon.x;　　//ねこボタンを押したときのコード
        if (f == true&&neko<=kingaku)
        {
            Debug.Log("ねこ出陣");
            kingaku -= neko;
            NekoCon.x = false;
        }
      
        if (kingaku<saidai-0.1f)//金額の最大値がsaidaiの値
        kingaku += Time.deltaTime*100;//1秒間に100円ずつ増える
        this.kingakuText.GetComponent<Text>().text = ((int)kingaku)+"/"+saidai+"円";//現在の金額と最大値の金額をTextに表示
    }
}
