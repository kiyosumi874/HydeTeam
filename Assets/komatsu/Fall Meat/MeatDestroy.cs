using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatDestroy : MonoBehaviour
{
    //変数宣言
    const float ScreenHeight = -5.0f; //画面の高さ

    // Update is called once per frame
    void Update()
    {
        //画面外に出たら削除する
        if (transform.position.y <= ScreenHeight)
        {
            Destroy(gameObject);
        }
    }
}
