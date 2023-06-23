using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// カウントダウンしていく
/// </summary>
public class CountDown : MonoBehaviour
{
    [SerializeField][Header("カウントダウンの数字の描画先")] private Image countDownImg;
    [SerializeField][Header("追加した順番に描画する")] private List<Sprite> numberSprite;
    [SerializeField][Header("カウントダウン終了後に描画する奴")] private Sprite endSprite;
    [SerializeField][Header("カウントダウン終了後に動く")] private List<GameObject> postCountDownObjects;
    [SerializeField][Header("数えたい時間")] private float observationTime;
    [SerializeField][Header("カウントダウン後のディレイ")] private float delayTime;
    [SerializeField][Header("数字を描画するときのアルファ値")][Range(0f, 1f)] private float numberAlfaValue;
    private float elaspedTime;//経過時間

    public bool finishFlag { get; private set; }    // 計測終了判定フラグ

    // Start is called before the first frame update
    void Start()
    {
        //カウントダウン終了まで止まってもらう
        foreach (GameObject obj in postCountDownObjects)
        {
            obj.SetActive(false);
        }
        // フラグの初期設定
        finishFlag = false;
        Color color = countDownImg.color;
        color.a = 0;
        countDownImg.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        // 制限時間が0秒以下なら何もしない
        if (finishFlag)
        {
            return;
        }
        //経過時間を更新
        elaspedTime += Time.deltaTime;
        
        //経過時間が設定時間を上回ったら
        if (observationTime < elaspedTime) 
        {
            countDownImg.sprite = endSprite;
            //遅延時間分も終了したら
            if (observationTime + delayTime < elaspedTime)
            {
                finishFlag = true;
                //数字の描画を終了させる
                Color color = countDownImg.color;
                color.a = 0;
                countDownImg.color = color;
                //カウントダウン終了後に動くやつを動かす
                foreach (GameObject obj in postCountDownObjects)
                {
                    obj.SetActive(true);
                }
            }
        }
        else
        {
            //経過時間が上回ってないならスプライトを更新
            if (observationTime - elaspedTime < numberSprite.Count)
            {
                int integerNum = Mathf.FloorToInt(observationTime - elaspedTime);
                countDownImg.sprite = numberSprite[integerNum];
                //見える状態にする
                Color color = countDownImg.color;
                color.a = numberAlfaValue;
                countDownImg.color = color;
            }
        }
    }
}
