using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MeetGenerator : MonoBehaviour
{
    //�ϐ��錾
    public GameObject Meat; //������
    GameObject C_Meat; //�R�s�[���ꂽ������
    const float span = 0.2f; //�����˂��o���Ԋu
    float deltatime = 0; //�f���^�^�C��
    bool TapBottan = false; //�{�^����������Ă��邩�ǂ���
    float MeatX = 0;
    float MeatY = 4.0f;

    // Update is called once per frame
    void Update()
    {
        //�f���^�^�C���v��
        this.deltatime += Time.deltaTime;

        //�{�^�����m
        //Enter��space�����N���b�N��true�ɂ���
        if(Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            TapBottan = true;
        }
        else
        {
            TapBottan=false;
        }

        //�{�^����������Ă���Ƃ��ɓ����˂𗎂Ƃ�
        if(TapBottan && deltatime >= span)�@//span��deltatime�ŗ��Ƃ��Ԋu�𐧌䂷��
        {
            this.deltatime = 0;�@//�f���^�^�C�����Z�b�g
            C_Meat = Instantiate(Meat); //�R�s�[�𐶐�����
            //�R�s�[���������˂̐ݒ�
            C_Meat.transform.position = new Vector2(MeatX,MeatY); //�ꏊ
            C_Meat.AddComponent<Rigidbody2D>(); //����
        }
    }
}
