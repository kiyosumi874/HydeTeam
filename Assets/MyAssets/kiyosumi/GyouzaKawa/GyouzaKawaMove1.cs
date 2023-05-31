using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 餃子の皮の子クラス(軌道だけ変える)
/// </summary>
public class GyouzaKawaMove1 : GyouzaKawaMoveBase
{
    private float rad = 0.0f;
    protected override void MoveLeft()
    {
        rad += Mathf.PI / 180.0f;
        this.transform.Translate(-power * 3.0f * Time.deltaTime, Mathf.Cos(rad) / Random.Range(20.0f, 100.0f), 0.0f);
    }

    protected override void MoveRight()
    {
        this.transform.Translate(power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
