using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour
{
    [SerializeField] private Image fadeImg;//シーン遷移する際にアルファ値をいじる
    [SerializeField] [Header("フェードアウト後に動く")] private List<GameObject> postFadeOutRunObject;
    //フェードアウト終了したか
    public bool isEndFadeOut { get; private set; }
    

    private void Start()
    {
        isEndFadeOut = false;
        //フェードアウトしてから動くやつを動けるようにする
        foreach (GameObject obj in postFadeOutRunObject)
        {
            obj.SetActive(false);
        }
        FadeOut();
    }
    
    /// <summary>
    /// だんだん見えなくなるよ
    /// </summary>
    public void FadeIn()
    {
        fadeImg.GameObject().SetActive(true);
        fadeImg.DOFade(
                1.0f,       // 指定数値まで画像のα値を変化させる
                1.0f)       // アニメーション時間
                .SetEase(Ease.Linear);
        
    }
    /// <summary>
    /// だんだん見えるようになるよ
    /// </summary>
    public void FadeOut()
    {
        fadeImg.GameObject().SetActive(true);
        fadeImg.DOFade(
                0.0f,       // 指定数値まで画像のα値を変化させる
                1.0f)       // アニメーション時間
                .SetEase(Ease.Linear);
        StartCoroutine(EndFadeOut());
    }
    /// <summary>
    /// フェードインしたらさえぎってた画像の当たり判定を消す
    /// </summary>
    /// <returns></returns>
    IEnumerator EndFadeOut()
    {
        //大体透明になったら
        yield return new WaitUntil(() => fadeImg.color.a < 0.01f); 
        fadeImg.GameObject().SetActive(false);
        isEndFadeOut = true;
        //フェードアウトしてから動くやつを動けるようにする
        foreach(GameObject obj in postFadeOutRunObject)
        {
            obj.SetActive(true);
        }
        yield  break;
    }
}
