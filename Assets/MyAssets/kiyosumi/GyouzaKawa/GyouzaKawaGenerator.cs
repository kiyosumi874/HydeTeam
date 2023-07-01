using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �L�q�̔�B�𐶐�����N���X
/// </summary>
public class GyouzaKawaGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> gyouzaKawaPrefabs; // �L�q�̔�B�̃v���n�u
    private int prefabIndex; // gyouzaKawaPrefabs�̓Y����
    private int prefabSize; // gyouzaKawaPrefabs�̒���Prefab�̐�

    private float nowTime; // nowTime������������Ă���o�߂�������
    private float instantiateTime; // ���ɐV�����L�q�̔炪���������܂ł̎���
    private float spriteChangeSpan;//sprite�̕ύX����^�C�~���O
    [SerializeField] private List<string> stringPrefab;
    [SerializeField] private Text text;
    [SerializeField] private float randTimeMax = 6.0f; // nextTime�̃����_���l�̍ő�l
    [SerializeField] private float randTimeMin = 3.0f; // nextTime�̃����_���l�̍ŏ��l

    /// <summary>
    /// ���̃N���X���������ꂽ�Ƃ��ŏ��Ɉ��Ăяo�����֐�
    /// </summary>
    void Start()
    {
        nowTime = 0.0f;
        instantiateTime = Random.Range(randTimeMin, randTimeMax);
        prefabSize = gyouzaKawaPrefabs.Count;
        prefabIndex = Random.Range(0, prefabSize);
        spriteChangeSpan = instantiateTime / stringPrefab.Count;
    }

    /// <summary>
    /// �X�V
    /// </summary>
    void Update()
    {
        if (CheckIsInstantiate())
        {
            // �L�q�̔�Prefab�𐶐�
            Instantiate(gyouzaKawaPrefabs[prefabIndex], this.transform);
            CleanUpAfterInstantiate();
        }
        ChangeString();
        // ���Ԃ�i�߂�
        nowTime += Time.deltaTime;
    }

    /// <summary>
    /// ���Ԃ��L�q�̔�Prefab�̓Y������������
    /// </summary>
    private void CleanUpAfterInstantiate()
    {
        nowTime = 0.0f;
        instantiateTime = Random.Range(randTimeMin, randTimeMax);
        prefabIndex = Random.Range(0, prefabSize);
        spriteChangeSpan = instantiateTime / stringPrefab.Count;
    }

    /// <summary>
    /// �V�����L�q�̔�𐶐��ł��邩�`�F�b�N
    /// </summary>
    /// <returns>�����ł���Ȃ�true</returns>
    private bool CheckIsInstantiate()
    {
        return nowTime > instantiateTime;
    }
    /// <summary>
    /// ����o���\����������
    /// </summary>
    private void ChangeString()
    {
        int stringIndex = (int)(nowTime/ spriteChangeSpan);
        text.text = stringPrefab[stringIndex];
    }
}
