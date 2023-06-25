using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawScore : MonoBehaviour
{
    //スコア表示
    public int GyozaNum = 0;        //餃子の数
    public Text ScoreText;      //スコアを表示するテキスト

    //レベル表示
    public Text RankText;       //ランクを表示するテキスト

    //音楽再生
    public AudioClip drumroll;  //ドラムロールの音源
    AudioSource audioSource;

    //フラグ関連
    public GyouzaFall gyouzafall;
    bool DrawscoreSetFlg;

    //パネル
    public GameObject panel;    //パネル

    enum RANK   //ランク
    {
        beginner = 1,   //半分
        middle = 3,     //三分の二
        master = 5      //全部作れた
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  //audioSouseを取得
        audioSource.PlayOneShot(drumroll);          //ドラムロールを再生
        panel.SetActive(false);                     //パネルの表示を無効にする
        GyozaNum = GyouzaCounter.Get();             //餃子の数を取得する
    }

    // Update is called once per frame
    void Update()
    {
        //フラグを取得する
        DrawscoreSetFlg = gyouzafall.GetDrawscoreSetFlg();
        //フラグがtrueだったらスコアを描画する
        if(DrawscoreSetFlg == true)
        {
            //パネルを表示する
            panel.SetActive(true);
            //スコア表示
            ScoreText.text = "作った餃子の数：" + GyozaNum;
            //ランク表示
            switch (GyozaNum)//スコアに応じてランクを変更する
            {
                case > (int)RANK.master:
                    RankText.text = "貴方のランクは\n\n餃子マスター";
                    break;
                case > (int)RANK.middle:
                    RankText.text = "貴方のランクは\n\n餃子ミドル";
                    break;
                case > (int)RANK.beginner:
                    RankText.text = "貴方のランクは\n\n餃子ビギナー";
                    break;
                default:
                    RankText.text = "貴方のランクは\n\nただの餃子";
                    break;
            }
        }
    }
}
