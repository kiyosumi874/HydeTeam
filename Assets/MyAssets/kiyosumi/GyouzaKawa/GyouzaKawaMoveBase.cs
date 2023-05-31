using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 餃子の皮の親クラス
/// </summary>
public class GyouzaKawaMoveBase : MonoBehaviour
{
    [SerializeField] private bool isLeftDir = true; // 左に向けで発射するか？
    [SerializeField] private Sprite yakiGyouza; // 餃子の画像
    [SerializeField, Range(0.0f, 10.0f)] private float deleteTime = 1.0f; // 餃子が表示されてから消えるまでの時間
    [SerializeField, Range(0.0f, 10.0f)] protected float power = 1.0f; // 餃子の皮が飛ぶ速さ
    [SerializeField, Range(0, 10)] private float randomPower = 0; // 餃子の皮が飛ぶ速さのランダムの幅
    private bool isCombination = false; // 皮と肉だねが合体したらtrue
    private float time = 0.0f; // 合体してからの時間

    /// <summary>
    /// このクラスが生成されたとき最初に一回呼び出される関数
    /// </summary>
    void Start()
    {
        power *= Random.Range(1.0f - randomPower / 10.0f, 1.0f + randomPower / 10.0f);
    }

    /// <summary>
    /// 更新
    /// </summary>
    void Update()
    {
        // 合体したら移動しない
        if (isCombination)
        {
            time += Time.deltaTime;
            if (deleteTime < time)
            {
                Destroy(this.gameObject);
            }
            return;
        }

        // 左方向に飛ばす場合
        if (isLeftDir)
        {
            MoveLeft();
            return;
        }

        // 右方向に飛ばす場合
        MoveRight();
    }

    /// <summary>
    /// 左方向に飛ばす関数
    /// </summary>
    virtual protected void MoveLeft()
    {
        this.transform.Translate(-power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    /// <summary>
    /// 右方向に飛ばす関数
    /// </summary>
    virtual protected void MoveRight()
    {
        this.transform.Translate(power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    /// <summary>
    /// 当たり判定
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 餃子の皮を消す処理
        if (collision.gameObject.CompareTag("GyouzaKawaDestroyer"))
        {
            Destroy(this.gameObject);
        }

        // 肉だねと合体して餃子にする処理
        if (collision.gameObject.CompareTag("Meet"))
        {
            isCombination = true;
            GyouzaCounter.Count();
            Debug.Log(GyouzaCounter.Get());
            GetComponent<SpriteRenderer>().sprite = yakiGyouza;
            GetComponent<CircleCollider2D>().enabled = false;
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
    }
}
