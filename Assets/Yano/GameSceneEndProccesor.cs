using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// タイマーが0になったら次のシーンに行くよ
/// </summary>
public class GameSceneEndProccesor : MonoBehaviour
{
    [SerializeField] private TimeCount timer;//遊んでいるときの時間を計る
    [SerializeField] private SceneChangeProccesor sceneChange;//シーンを変更するやつ

    private void Update()
    {
        if(timer.finishFlag)
        {
            sceneChange.ChangeScene();
        }
    }
}
