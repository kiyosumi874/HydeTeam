using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �L�q�̔�̈ړ��ʂ�ۑ�����
/// </summary>
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CreateGyouzaKawaMoveParameter")]
public class GyouzaKawaMoveParametor : ScriptableObject
{
    [SerializeField][Header("�ړ����Ȃ���Ȃ����")][Range(0.0f,180.0f)] private float setAddRad;
    public float addRad { get => setAddRad; }
    [SerializeField][Header("�ړ���")][Range(0.01f, 10.0f)] private float setMovePower;
    public float movePower { get => setMovePower; }
    [SerializeField][Header("�ړ��ʂ����������Ƃ��ɕ����o��")][Range(0.0f, 10.0f)] private float setMovePowerSeed;
    public float movePowerSeed { get => setMovePowerSeed; }
    [SerializeField][Header("�ړ��̉��Z��")][Range(0.00f, 10.0f)] private float setAddMovePower;
    public float addMovePower { get => setAddMovePower; }
}
