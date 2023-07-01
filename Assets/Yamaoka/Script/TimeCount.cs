using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TimeCount : MonoBehaviour
{
    [SerializeField]
    private int minute;       // 分
    [SerializeField]
    private float seconds;    // 秒

    private float totalTime;    // 制限時間
    private float oldSeconds;   // ひとつ前の秒数

    [SerializeField]
    private Text timeText;  // 時間表示テキスト

    public bool finishFlag = false;    // 計測終了判定フラグ

    [SerializeField]
    private SceneChanger sceneChanger;

    // ゲーム終了時に、非表示にするゲームオブジェクト
    [SerializeField]
    private List<GameObject> stopGameObjects;

    // Start is called before the first frame update
    void Start()
    {
        sceneChanger.GetComponent<SceneChanger>();

        // 制限時間の設定
        totalTime = minute * 60 + seconds;
        oldSeconds = 0.0f;

        // フラグの初期設定
        finishFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        // 制限時間が0秒以下なら何もしない
        if( totalTime <= 0.0f )
        {
            return;
        }

        // 制限時間を計測(〇分〇秒→〇秒にして計算を行う)
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        // 時間を再設定(更新)
        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        // 時間をテキスト表示
        if((int)seconds != (int)oldSeconds)
        {
            timeText.text = 
                minute.ToString("00") + " : " + ((int)seconds).ToString("00");
        }

        // oldSecondsを更新
        oldSeconds = seconds;

        // 0秒以下になったら終了
        if(totalTime <= 0.0f)
        {
            Debug.Log("計測終了");
            totalTime = 0.0f;
            minute = 0;
            seconds = 0.0f;
            finishFlag = true;
        }

        if(finishFlag)
        {
            DOVirtual.DelayedCall(2, () =>
            sceneChanger.ChangeScene("Result Scene")
            );

            for(int i = 0; i < stopGameObjects.Count; i++)
            {
                stopGameObjects[i].SetActive(false);
            }
        }
    }
}
