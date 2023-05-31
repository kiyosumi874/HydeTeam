using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// �L�q�̔�̐e�N���X
/// </summary>
public class GyouzaKawaMoveBase : MonoBehaviour
{
    [SerializeField] private bool isLeftDir = true; // ���Ɍ����Ŕ��˂��邩�H
    [SerializeField] private Sprite yakiGyouza; // �L�q�̉摜
    [SerializeField, Range(0.0f, 10.0f)] private float deleteTime = 1.0f; // �L�q���\������Ă��������܂ł̎���
    [SerializeField, Range(0.0f, 10.0f)] protected float power = 1.0f; // �L�q�̔炪��ԑ���
    [SerializeField, Range(0, 10)] private float randomPower = 0; // �L�q�̔炪��ԑ����̃����_���̕�
    private bool isCombination = false; // ��Ɠ����˂����̂�����true
    private float time = 0.0f; // ���̂��Ă���̎���

    /// <summary>
    /// ���̃N���X���������ꂽ�Ƃ��ŏ��Ɉ��Ăяo�����֐�
    /// </summary>
    void Start()
    {
        power *= Random.Range(1.0f - randomPower / 10.0f, 1.0f + randomPower / 10.0f);
    }

    /// <summary>
    /// �X�V
    /// </summary>
    void Update()
    {
        // ���̂�����ړ����Ȃ�
        if (isCombination)
        {
            time += Time.deltaTime;
            if (deleteTime < time)
            {
                Destroy(this.gameObject);
            }
            return;
        }

        // �������ɔ�΂��ꍇ
        if (isLeftDir)
        {
            MoveLeft();
            return;
        }

        // �E�����ɔ�΂��ꍇ
        MoveRight();
    }

    /// <summary>
    /// �������ɔ�΂��֐�
    /// </summary>
    virtual protected void MoveLeft()
    {
        this.transform.Translate(-power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    /// <summary>
    /// �E�����ɔ�΂��֐�
    /// </summary>
    virtual protected void MoveRight()
    {
        this.transform.Translate(power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    /// <summary>
    /// �����蔻��
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �L�q�̔����������
        if (collision.gameObject.CompareTag("GyouzaKawaDestroyer"))
        {
            Destroy(this.gameObject);
        }

        // �����˂ƍ��̂����L�q�ɂ��鏈��
        if (collision.gameObject.CompareTag("Meet"))
        {
            isCombination = true;
            GyouzaCounter.Count();
            Debug.Log(GyouzaCounter.Get());
            GetComponent<SpriteRenderer>().sprite = yakiGyouza;
            GetComponent<CircleCollider2D>().enabled = false;
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
    }
}
