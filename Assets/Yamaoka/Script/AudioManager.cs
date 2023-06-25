using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;    //AudioSource
    // AudioClip
    [SerializeField]
    private AudioClip gameBGM;
    [SerializeField]
    private AudioClip titleBGM;
    [SerializeField]
    private AudioClip resultBGM;
    [SerializeField]
    private AudioClip hit;

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

}
