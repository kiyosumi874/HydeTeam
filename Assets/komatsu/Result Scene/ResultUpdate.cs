using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUpdate : MonoBehaviour
{
    //�X�R�A�\��
    public int Score;//�X�R�A
    public Text ScoreText;//�X�R�A��\������e�L�X�g

    //���x���\��
    public Text RankText;//�����N��\������e�L�X�g

    enum RANK//�����N
    {
        beginner = 50,//���S��
        middle = 500,//����
        master = 1000//�}�X�^�[
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�X�R�A�\��
        ScoreText.text = "Score�F"+ Score;
        //�����N�\��
        switch (Score)//�X�R�A�ɉ����ă����N��ύX����
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
