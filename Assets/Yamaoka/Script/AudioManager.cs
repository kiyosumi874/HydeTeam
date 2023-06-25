using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //AudioSource
    [SerializeField]
    private AudioSource audioSource;
    // AudioClip
    [SerializeField]
    private AudioClip gameBGM;
    [SerializeField]
    private AudioClip titleBGM;
    [SerializeField]
    private AudioClip resultBGM;

    // シングルトンのインスタンス
    public static AudioManager instance;

    public bool onTitleScene = false;
    public bool onGameScene = false;
    public bool onResultScene = false;

    private void Start()
    {
        if (onTitleScene)
        {
            TitleBGM();
        }
        else if (onGameScene)
        {
            GameBGM();
        }
        else if (onResultScene)
        {
            ResultBGM();
        }
    }

    private void Update()
    {

    }

    public void GameBGM()
    {
        audioSource.PlayOneShot(gameBGM);
    }

    public void TitleBGM()
    {
        audioSource.PlayOneShot(titleBGM);
    }

    public void ResultBGM()
    {
        audioSource.PlayOneShot(resultBGM);
    }


    /// <summary>
    /// 他のゲームオブジェクトにアタッチされているか調べる
    /// アタッチされている場合は破棄する。
    /// </summary>
    void CheckInstance()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }

}
