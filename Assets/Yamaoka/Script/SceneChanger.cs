using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    // ���̃V�[���̖��O
    public string nextScene;
    // �t�F�[�h���n�߂�܂ł̎���
    public float delayTime;

    // �t�F�[�h�C���p�摜
    public Image fadeImg;
    Color startAlphaNum;

    // Start is called before the first frame update
    void Start()
    {
        // fadeImg�̃A���t�@�l�̏����ݒ�
        // �t�F�[�h�A�E�g����J�n���邽��
        startAlphaNum = fadeImg.color;
        startAlphaNum.a = 0.0f;
        fadeImg.color = startAlphaNum;
    }

    public void Update()
    {

    }

    /// <summary>
    /// �V�[���J��
    /// </summary>
    /// <param name="sceneName">���̃V�[���̖��O</param>
    public void ChangeScene(string sceneName)
    {
        StartFadeIn();
        DOVirtual.DelayedCall(delayTime, () =>
        {
            // �V�[���J��
            SceneManager.LoadScene(sceneName);
        });
    }

    /// <summary>
    /// �t�F�[�h�C���J�n
    /// </summary>
    public void StartFadeIn()
    {
        fadeImg.DOFade(
            1.0f,       // �w�萔�l�܂ŉ摜�̃��l��ω�������
            1.0f)       // �A�j���[�V��������
            .SetEase(Ease.Linear);
    }
}
