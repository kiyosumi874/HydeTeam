using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyouzaFall : MonoBehaviour
{
    public int GyozaNum = 10;//降らせる餃子の数
    public GameObject Gyoza;//餃子のオブジェクト
    GameObject c_Gyoza;//コピーをした餃子
    float GyozaX = 0;//餃子を落とす位置のY座標
    const float GyozaY = 200.0f;//餃子を落とす位置のY座標

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < GyozaNum; i++)
        {
            //指定された数だけ餃子を落とす
            c_Gyoza = Instantiate(Gyoza); //コピーを生成
            //コピーした肉だねの設定
            GyozaX = Random.Range(-400.0f, 400.0f);//X軸の値をランダムで決める
            c_Gyoza.transform.position = new Vector2(GyozaX, GyozaY); //場所
            c_Gyoza.AddComponent<Rigidbody2D>(); //落下
        }
    }
}
