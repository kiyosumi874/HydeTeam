using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeProccesor : MonoBehaviour
{
    // ���̃V�[���̖��O
    [SerializeField] private string nextScene;
    // �t�F�[�h���n�߂�܂ł̎���
    [SerializeField] private float delayTime;
    /// <summary>
    /// �V�[���J��
    /// </summary>
    public void ChangeScene()
    {
        //delayTime���҂��Ă���V�[���J��
        DOVirtual.DelayedCall(delayTime, () =>
        {
            // �V�[���J��
            SceneManager.LoadScene(nextScene);
        });
    }
}
