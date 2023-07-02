using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 餃子の皮の子クラス(軌道だけ変える)
/// </summary>
public class GyouzaKawaMove2 : GyouzaKawaMoveBase
{
    [SerializeField] [Header("移動するときのパラメータ")] private GyouzaKawaMoveParametor moveParamator;
    private float rad = 0.0f;

    private void Start()
    {
        power = moveParamator.movePower * Random.Range(1.0f - moveParamator.movePowerSeed / 10.0f, 1.0f + moveParamator.movePowerSeed / 10.0f);
    }
    protected override void MoveLeft()
    {
        Debug.Log(moveParamator.addRad);
        if (moveParamator.addRad > 0.01f)
        {
            rad += Mathf.PI / 180.0f * moveParamator.addRad;
            this.transform.Translate(-power * 3.0f * Time.deltaTime, Mathf.Cos(rad) / Random.Range(20.0f, 100.0f), 0.0f);
        }
        else
        { 
            this.transform.Translate(-power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
        }
        power += moveParamator.addMovePower;
    }

    protected override void MoveRight()
    {
        this.transform.Translate(power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
