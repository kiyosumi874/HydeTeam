using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    void Update()
    {
        EndGame();
    }

    /// <summary>
    /// ゲーム終了処理
    /// </summary>
    private void EndGame()
    {
        //Escが押された時
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            // ゲームプレイ終了
            UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();//ゲームプレイ終了
#endif
        }

    }
}
