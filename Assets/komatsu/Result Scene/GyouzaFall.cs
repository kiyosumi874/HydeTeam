using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyouzaFall : MonoBehaviour
{
    public int GyouzaNum = 0;                //�~�点���L�q�̐�
    public GameObject Gyoza;                //�L�q�̃I�u�W�F�N�g
    GameObject c_Gyoza;                     //�R�s�[�������L�q
    float GyozaX = 0;                       //�L�q�𗎂Ƃ��ʒu��Y���W
    const float GyozaY = 5.0f;              //�L�q�𗎂Ƃ��ʒu��Y���W
    int Cnt = 0;                            //�L�q�𗎂Ƃ������𐔂���J�E���g
    const int MaxGyouzaNum = 20;             //�L�q�̐��̍ő�l
    float deltatime = 0;                    //�f���^�^�C��
    const float span = 0.45f;               //�L�q�𗎂Ƃ��N�[���^�C��
    public bool DrawscoreSetFlg = false;    //DrawScore�����邩�ǂ����̃t���O

    private void Start()
    {
        GyouzaNum = GyouzaCounter.Get();
    }

    // Update is called once per frame
    void Update()
    {
        //�N�[���^�C�����������ꂽ��w�肳�ꂽ�������L�q�𗎂Ƃ�
        if (Cnt < MaxGyouzaNum && deltatime > span)�@
        {
            //�N�[���^�C�����Z�b�g
            deltatime = 0;
            if(Cnt < GyouzaNum)//�L�q�̐��������Ƃ�
            {
                //�L�q�𐶐����ė��Ƃ�
                c_Gyoza = Instantiate(Gyoza); //�R�s�[�𐶐�
                GyozaX = Random.Range(-10.0f, 10.0f);//X���̒l�������_���Ō��߂�
                c_Gyoza.transform.position = new Vector2(GyozaX, GyozaY); //�ꏊ
                c_Gyoza.AddComponent<Rigidbody2D>(); //����
            }
            Cnt++;
        }
        //�L�q�����ׂė��Ƃ��I�������ScoreDraw�����s����
        else if(Cnt == MaxGyouzaNum && deltatime > span)
        {
            //Flg��true�ɂ���
            DrawscoreSetFlg = true;
        }
        else
        {
            deltatime += Time.deltaTime;
        }
    }

    ///
    public bool GetDrawscoreSetFlg()
    {
        //Flg��DrawScore�Ɉ����n��
        return DrawscoreSetFlg;
    }
}
