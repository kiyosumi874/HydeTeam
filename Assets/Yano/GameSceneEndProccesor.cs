using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �^�C�}�[��0�ɂȂ����玟�̃V�[���ɍs����
/// </summary>
public class GameSceneEndProccesor : MonoBehaviour
{
    [SerializeField] private TimeCount timer;//�V��ł���Ƃ��̎��Ԃ��v��
    [SerializeField] private SceneChangeProccesor sceneChange;//�V�[����ύX������

    private void Update()
    {
        if(timer.finishFlag)
        {
            sceneChange.ChangeScene();
        }
    }
}
