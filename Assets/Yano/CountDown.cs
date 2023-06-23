using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �J�E���g�_�E�����Ă���
/// </summary>
public class CountDown : MonoBehaviour
{
    [SerializeField][Header("�J�E���g�_�E���̐����̕`���")] private Image countDownImg;
    [SerializeField][Header("�ǉ��������Ԃɕ`�悷��")] private List<Sprite> numberSprite;
    [SerializeField][Header("�J�E���g�_�E���I����ɕ`�悷��z")] private Sprite endSprite;
    [SerializeField][Header("�J�E���g�_�E���I����ɓ���")] private List<GameObject> postCountDownObjects;
    [SerializeField][Header("������������")] private float observationTime;
    [SerializeField][Header("�J�E���g�_�E����̃f�B���C")] private float delayTime;
    [SerializeField][Header("������`�悷��Ƃ��̃A���t�@�l")][Range(0f, 1f)] private float numberAlfaValue;
    private float elaspedTime;//�o�ߎ���

    public bool finishFlag { get; private set; }    // �v���I������t���O

    // Start is called before the first frame update
    void Start()
    {
        //�J�E���g�_�E���I���܂Ŏ~�܂��Ă��炤
        foreach (GameObject obj in postCountDownObjects)
        {
            obj.SetActive(false);
        }
        // �t���O�̏����ݒ�
        finishFlag = false;
        Color color = countDownImg.color;
        color.a = 0;
        countDownImg.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        // �������Ԃ�0�b�ȉ��Ȃ牽�����Ȃ�
        if (finishFlag)
        {
            return;
        }
        //�o�ߎ��Ԃ��X�V
        elaspedTime += Time.deltaTime;
        
        //�o�ߎ��Ԃ��ݒ莞�Ԃ���������
        if (observationTime < elaspedTime) 
        {
            countDownImg.sprite = endSprite;
            //�x�����ԕ����I��������
            if (observationTime + delayTime < elaspedTime)
            {
                finishFlag = true;
                //�����̕`����I��������
                Color color = countDownImg.color;
                color.a = 0;
                countDownImg.color = color;
                //�J�E���g�_�E���I����ɓ�����𓮂���
                foreach (GameObject obj in postCountDownObjects)
                {
                    obj.SetActive(true);
                }
            }
        }
        else
        {
            //�o�ߎ��Ԃ������ĂȂ��Ȃ�X�v���C�g���X�V
            if (observationTime - elaspedTime < numberSprite.Count)
            {
                int integerNum = Mathf.FloorToInt(observationTime - elaspedTime);
                countDownImg.sprite = numberSprite[integerNum];
                //�������Ԃɂ���
                Color color = countDownImg.color;
                color.a = numberAlfaValue;
                countDownImg.color = color;
            }
        }
    }
}
