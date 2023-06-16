using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUpdate : MonoBehaviour
{
    //スコア表示
    public int Score;//スコア
    public Text ScoreText;//スコアを表示するテキスト

    //レベル表示
    public Text RankText;//ランクを表示するテキスト

    enum RANK//ランク
    {
        beginner = 50,//初心者
        middle = 500,//中級
        master = 1000//マスター
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スコア表示
        ScoreText.text = "Score："+ Score;
        //ランク表示
        switch (Score)//スコアに応じてランクを変更する
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
