using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �L�q������ꂽ���\�����鉼�N���X
/// </summary>
public class CountUI_kiyo : MonoBehaviour
{
    // �X�V
    void Update()
    {
        GetComponent<Text>().text = GyouzaCounter.Get().ToString();
    }
}
