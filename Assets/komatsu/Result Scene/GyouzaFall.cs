using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyouzaFall : MonoBehaviour
{
    public int GyozaNum = 10;//�~�点���L�q�̐�
    public GameObject Gyoza;//�L�q�̃I�u�W�F�N�g
    GameObject c_Gyoza;//�R�s�[�������L�q
    float GyozaX = 0;//�L�q�𗎂Ƃ��ʒu��Y���W
    const float GyozaY = 200.0f;//�L�q�𗎂Ƃ��ʒu��Y���W

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < GyozaNum; i++)
        {
            //�w�肳�ꂽ�������L�q�𗎂Ƃ�
            c_Gyoza = Instantiate(Gyoza); //�R�s�[�𐶐�
            //�R�s�[���������˂̐ݒ�
            GyozaX = Random.Range(-400.0f, 400.0f);//X���̒l�������_���Ō��߂�
            c_Gyoza.transform.position = new Vector2(GyozaX, GyozaY); //�ꏊ
            c_Gyoza.AddComponent<Rigidbody2D>(); //����
        }
    }
}
