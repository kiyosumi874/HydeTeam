using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �L�q����������𐔂�����擾����ÓI�N���X
/// </summary>
public class GyouzaCounter
{
    static private int count = 0; // �L�q���������

    // ������L�q�̐���1���₷
    static public void Count()
    {
        count++;
    }

    // ������L�q�̐����擾����
    static public int Get()
    {
        return count;
    }
}
