using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result_Gyouza : MonoBehaviour
{
    // �Ă��L�q�摜��Prefab
    public GameObject gyouzaYaki;
    // �L�q�𐶐�����ʒu��Transform
    public Transform createPosition;
    // ���������L�q�̐�
    public int gyouzaNum;
    // ���݂��L�q�̐�
    private int nouCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // �ł����L�q�̐����擾
        gyouzaNum = GyouzaCounter.Get();
    }

    // Update is called once per frame
    void Update()
    {
        // ���݂��L�q�̐����������鐔���ȉ��̂Ƃ�
        if(nouCount < gyouzaNum)
        {
            // �v���n�u��x���W�̈ʒu�������_���Őݒ�
            float x = Random.Range(-5.0f, 5.0f);
            Vector3 pos = new Vector3(x, createPosition.position.y, createPosition.position.z);
            // �L�q�𐶐�
            Instantiate(gyouzaYaki, pos,createPosition.rotation);
            // ���݂��L�q�̐������Z
            nouCount++;
        }
    }
}
