using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MeetGenerator : MonoBehaviour
{
    //変数宣言
    public GameObject Meat; //肉だね
    GameObject C_Meat; //コピーされた肉だね
    const float span = 0.2f; //肉だねを出す間隔
    float deltatime = 0; //デルタタイム
    bool TapBottan = false; //ボタンが押されているかどうか
    float MeatX = 0;
    float MeatY = 4.0f;

    // Update is called once per frame
    void Update()
    {
        //デルタタイム計測
        this.deltatime += Time.deltaTime;

        //ボタン感知
        //Enterかspaceか左クリックでtrueにする
        if(Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            TapBottan = true;
        }
        else
        {
            TapBottan=false;
        }

        //ボタンが押されているときに肉だねを落とす
        if(TapBottan && deltatime >= span)　//spanとdeltatimeで落とす間隔を制御する
        {
            this.deltatime = 0;　//デルタタイムリセット
            C_Meat = Instantiate(Meat); //コピーを生成生成
            //コピーした肉だねの設定
            C_Meat.transform.position = new Vector2(MeatX,MeatY); //場所
            C_Meat.AddComponent<Rigidbody2D>(); //落下
        }
    }
}
