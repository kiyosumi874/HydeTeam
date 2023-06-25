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
    [SerializeField]
    private AudioClip hit;
    // シングルトンのインスタンス
    public static AudioManager instance;


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

    public void Hit()
    {
        audioSource.PlayOneShot(hit);
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
