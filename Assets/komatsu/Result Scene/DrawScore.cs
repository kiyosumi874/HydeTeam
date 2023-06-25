using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawScore : MonoBehaviour
{
    //�X�R�A�\��
    public int GyozaNum = 0;        //�L�q�̐�
    public Text ScoreText;      //�X�R�A��\������e�L�X�g

    //���x���\��
    public Text RankText;       //�����N��\������e�L�X�g

    //���y�Đ�
    public AudioClip drumroll;  //�h�������[���̉���
    AudioSource audioSource;

    //�t���O�֘A
    public GyouzaFall gyouzafall;
    bool DrawscoreSetFlg;

    //�p�l��
    public GameObject panel;    //�p�l��

    enum RANK   //�����N
    {
        beginner = 1,   //����
        middle = 3,     //�O���̓�
        master = 5      //�S����ꂽ
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  //audioSouse���擾
        audioSource.PlayOneShot(drumroll);          //�h�������[�����Đ�
        panel.SetActive(false);                     //�p�l���̕\���𖳌��ɂ���
        GyozaNum = GyouzaCounter.Get();             //�L�q�̐����擾����
    }

    // Update is called once per frame
    void Update()
    {
        //�t���O���擾����
        DrawscoreSetFlg = gyouzafall.GetDrawscoreSetFlg();
        //�t���O��true��������X�R�A��`�悷��
        if(DrawscoreSetFlg == true)
        {
            //�p�l����\������
            panel.SetActive(true);
            //�X�R�A�\��
            ScoreText.text = "������L�q�̐��F" + GyozaNum;
            //�����N�\��
            switch (GyozaNum)//�X�R�A�ɉ����ă����N��ύX����
            {
                case > (int)RANK.master:
                    RankText.text = "�M���̃����N��\n\n�L�q�}�X�^�[";
                    break;
                case > (int)RANK.middle:
                    RankText.text = "�M���̃����N��\n\n�L�q�~�h��";
                    break;
                case > (int)RANK.beginner:
                    RankText.text = "�M���̃����N��\n\n�L�q�r�M�i�[";
                    break;
                default:
                    RankText.text = "�M���̃����N��\n\n�������L�q";
                    break;
            }
        }
    }
}
