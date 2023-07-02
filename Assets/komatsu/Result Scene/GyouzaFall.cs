using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyouzaFall : MonoBehaviour
{
    public int GyouzaNum = 0;                //降らせる餃子の数
    public GameObject Gyoza;                //餃子のオブジェクト
    GameObject c_Gyoza;                     //コピーをした餃子
    float GyozaX = 0;                       //餃子を落とす位置のY座標
    const float GyozaY = 5.0f;              //餃子を落とす位置のY座標
    int Cnt = 0;                            //餃子を落とした数を数えるカウント
    const int MaxGyouzaNum = 20;             //餃子の数の最大値
    float deltatime = 0;                    //デルタタイム
    const float span = 0.45f;               //餃子を落とすクールタイム
    public bool DrawscoreSetFlg = false;    //DrawScoreをするかどうかのフラグ

    private void Start()
    {
        GyouzaNum = GyouzaCounter.Get();
    }

    // Update is called once per frame
    void Update()
    {
        //クールタイムが解除されたら指定された数だけ餃子を落とす
        if (Cnt < MaxGyouzaNum && deltatime > span)　
        {
            //クールタイムリセット
            deltatime = 0;
            if(Cnt < GyouzaNum)//餃子の数だけ落とす
            {
                //餃子を生成して落とす
                c_Gyoza = Instantiate(Gyoza); //コピーを生成
                GyozaX = Random.Range(-10.0f, 10.0f);//X軸の値をランダムで決める
                c_Gyoza.transform.position = new Vector2(GyozaX, GyozaY); //場所
                c_Gyoza.AddComponent<Rigidbody2D>(); //落下
            }
            Cnt++;
        }
        //餃子をすべて落とし終わったらScoreDrawを実行する
        else if(Cnt == MaxGyouzaNum && deltatime > span)
        {
            //Flgをtrueにする
            DrawscoreSetFlg = true;
        }
        else
        {
            deltatime += Time.deltaTime;
        }
    }

    ///
    public bool GetDrawscoreSetFlg()
    {
        //FlgをDrawScoreに引き渡す
        return DrawscoreSetFlg;
    }
}
