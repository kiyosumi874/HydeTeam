using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeProccesor : MonoBehaviour
{
    // 次のシーンの名前
    [SerializeField] private string nextScene;
    // フェードを始めるまでの時間
    [SerializeField] private float delayTime;
    /// <summary>
    /// シーン遷移
    /// </summary>
    public void ChangeScene()
    {
        //delayTime分待ってからシーン遷移
        DOVirtual.DelayedCall(delayTime, () =>
        {
            // シーン遷移
            SceneManager.LoadScene(nextScene);
        });
    }
}
