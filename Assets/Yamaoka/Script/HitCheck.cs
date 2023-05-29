using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheck : MonoBehaviour
{
    /// <summary>
    /// 当たり判定
    /// </summary>
    /// <param name="collision">当たったオブジェクト</param>
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Kawa タグを持つオブジェクトに当たったとき
        if(collision.gameObject.tag == "Kawa")
        {
            Debug.Log("Hit!!");
            // 自分を削除する
            Destroy(this.gameObject);
        }
    }
}
