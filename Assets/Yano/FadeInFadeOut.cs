using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour
{
    [SerializeField] private Image fadeImg;//�V�[���J�ڂ���ۂɃA���t�@�l��������
    [SerializeField] [Header("�t�F�[�h�A�E�g��ɓ���")] private List<GameObject> postFadeOutRunObject;
    //�t�F�[�h�A�E�g�I��������
    public bool isEndFadeOut { get; private set; }
    

    private void Start()
    {
        isEndFadeOut = false;
        //�t�F�[�h�A�E�g���Ă��瓮����𓮂���悤�ɂ���
        foreach (GameObject obj in postFadeOutRunObject)
        {
            obj.SetActive(false);
        }
        FadeOut();
    }
    
    /// <summary>
    /// ���񂾂񌩂��Ȃ��Ȃ��
    /// </summary>
    public void FadeIn()
    {
        fadeImg.GameObject().SetActive(true);
        fadeImg.DOFade(
                1.0f,       // �w�萔�l�܂ŉ摜�̃��l��ω�������
                1.0f)       // �A�j���[�V��������
                .SetEase(Ease.Linear);
        
    }
    /// <summary>
    /// ���񂾂񌩂���悤�ɂȂ��
    /// </summary>
    public void FadeOut()
    {
        fadeImg.GameObject().SetActive(true);
        fadeImg.DOFade(
                0.0f,       // �w�萔�l�܂ŉ摜�̃��l��ω�������
                1.0f)       // �A�j���[�V��������
                .SetEase(Ease.Linear);
        StartCoroutine(EndFadeOut());
    }
    /// <summary>
    /// �t�F�[�h�C�������炳�������Ă��摜�̓����蔻�������
    /// </summary>
    /// <returns></returns>
    IEnumerator EndFadeOut()
    {
        //��̓����ɂȂ�����
        yield return new WaitUntil(() => fadeImg.color.a < 0.01f); 
        fadeImg.GameObject().SetActive(false);
        isEndFadeOut = true;
        //�t�F�[�h�A�E�g���Ă��瓮����𓮂���悤�ɂ���
        foreach(GameObject obj in postFadeOutRunObject)
        {
            obj.SetActive(true);
        }
        yield  break;
    }
}
