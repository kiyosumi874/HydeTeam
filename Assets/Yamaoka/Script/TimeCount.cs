using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TimeCount : MonoBehaviour
{
    [SerializeField]
    private int minute;       // ��
    [SerializeField]
    private float seconds;    // �b

    private float totalTime;    // ��������
    private float oldSeconds;   // �ЂƂO�̕b��

    [SerializeField]
    private Text timeText;  // ���ԕ\���e�L�X�g

    public bool finishFlag = false;    // �v���I������t���O

    [SerializeField]
    private SceneChanger sceneChanger;

    // �Q�[���I�����ɁA��\���ɂ���Q�[���I�u�W�F�N�g
    [SerializeField]
    private List<GameObject> stopGameObjects;

    // Start is called before the first frame update
    void Start()
    {
        sceneChanger.GetComponent<SceneChanger>();

        // �������Ԃ̐ݒ�
        totalTime = minute * 60 + seconds;
        oldSeconds = 0.0f;

        // �t���O�̏����ݒ�
        finishFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        // �������Ԃ�0�b�ȉ��Ȃ牽�����Ȃ�
        if( totalTime <= 0.0f )
        {
            return;
        }

        // �������Ԃ��v��(�Z���Z�b���Z�b�ɂ��Čv�Z���s��)
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        // ���Ԃ��Đݒ�(�X�V)
        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        // ���Ԃ��e�L�X�g�\��
        if((int)seconds != (int)oldSeconds)
        {
            timeText.text = 
                minute.ToString("00") + " : " + ((int)seconds).ToString("00");
        }

        // oldSeconds���X�V
        oldSeconds = seconds;

        // 0�b�ȉ��ɂȂ�����I��
        if(totalTime <= 0.0f)
        {
            Debug.Log("�v���I��");
            totalTime = 0.0f;
            minute = 0;
            seconds = 0.0f;
            finishFlag = true;
        }

        if(finishFlag)
        {
            DOVirtual.DelayedCall(2, () =>
            sceneChanger.ChangeScene("Result Scene")
            );

            for(int i = 0; i < stopGameObjects.Count; i++)
            {
                stopGameObjects[i].SetActive(false);
            }
        }
    }
}
