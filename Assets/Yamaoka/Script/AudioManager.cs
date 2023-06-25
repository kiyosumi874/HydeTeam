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
    // �V���O���g���̃C���X�^���X
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
    /// ���̃Q�[���I�u�W�F�N�g�ɃA�^�b�`����Ă��邩���ׂ�
    /// �A�^�b�`����Ă���ꍇ�͔j������B
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
