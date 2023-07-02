using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// éLŽq‚Ì”ç‚ÌˆÚ“®—Ê‚ð•Û‘¶‚·‚é
/// </summary>
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CreateGyouzaKawaMoveParameter")]
public class GyouzaKawaMoveParametor : ScriptableObject
{
    [SerializeField][Header("ˆÚ“®‚µ‚È‚ª‚ç‹È‚ª‚é—Ê")][Range(0.0f,180.0f)] private float setAddRad;
    public float addRad { get => setAddRad; }
    [SerializeField][Header("ˆÚ“®—Ê")][Range(0.01f, 10.0f)] private float setMovePower;
    public float movePower { get => setMovePower; }
    [SerializeField][Header("ˆÚ“®—Ê‚ª¶¬‚³‚ê‚é‚Æ‚«‚É•‚ªo‚é")][Range(0.0f, 10.0f)] private float setMovePowerSeed;
    public float movePowerSeed { get => setMovePowerSeed; }
    [SerializeField][Header("ˆÚ“®‚Ì‰ÁŽZ—Ê")][Range(0.00f, 10.0f)] private float setAddMovePower;
    public float addMovePower { get => setAddMovePower; }
}
