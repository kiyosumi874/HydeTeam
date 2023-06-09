using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 餃子の皮の移動量を保存する
/// </summary>
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CreateGyouzaKawaMoveParameter")]
public class GyouzaKawaMoveParametor : ScriptableObject
{
    [SerializeField][Header("移動しながら曲がる量")][Range(0.0f,180.0f)] private float setAddRad;
    public float addRad { get => setAddRad; }
    [SerializeField][Header("移動量")][Range(0.01f, 10.0f)] private float setMovePower;
    public float movePower { get => setMovePower; }
    [SerializeField][Header("移動量が生成されるときに幅が出る")][Range(0.0f, 10.0f)] private float setMovePowerSeed;
    public float movePowerSeed { get => setMovePowerSeed; }
    [SerializeField][Header("移動の加算量")][Range(0.00f, 10.0f)] private float setAddMovePower;
    public float addMovePower { get => setAddMovePower; }
}
