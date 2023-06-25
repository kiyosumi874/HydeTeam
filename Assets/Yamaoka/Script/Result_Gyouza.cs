using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result_Gyouza : MonoBehaviour
{
    // 焼き餃子画像のPrefab
    public GameObject gyouzaYaki;
    // 餃子を生成する位置のTransform
    public Transform createPosition;
    // 生成する餃子の数
    public int gyouzaNum;
    // 現在の餃子の数
    private int nouCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // できた餃子の数を取得
        gyouzaNum = GyouzaCounter.Get();
    }

    // Update is called once per frame
    void Update()
    {
        // 現在の餃子の数が生成する数を以下のとき
        if(nouCount < gyouzaNum)
        {
            // プレハブのx座標の位置をランダムで設定
            float x = Random.Range(-5.0f, 5.0f);
            Vector3 pos = new Vector3(x, createPosition.position.y, createPosition.position.z);
            // 餃子を生成
            Instantiate(gyouzaYaki, pos,createPosition.rotation);
            // 現在の餃子の数を加算
            nouCount++;
        }
    }
}
