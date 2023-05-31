using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// �L�q�̔�̎q�N���X(�O�������ς���)
/// </summary>
public class GyouzaKawaMove0 : GyouzaKawaMoveBase
{
    protected override void MoveLeft()
    {
        this.transform.Translate(-power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    protected override void MoveRight()
    {
        this.transform.Translate(power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
