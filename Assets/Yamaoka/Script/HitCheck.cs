using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheck : MonoBehaviour
{
    /// <summary>
    /// �����蔻��
    /// </summary>
    /// <param name="collision">���������I�u�W�F�N�g</param>
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Kawa �^�O�����I�u�W�F�N�g�ɓ��������Ƃ�
        if(collision.gameObject.tag == "Kawa")
        {
            Debug.Log("Hit!!");
            // �������폜����
            Destroy(this.gameObject);
        }
    }
}
