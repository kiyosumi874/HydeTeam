using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GyouzaKawaMove0 : MonoBehaviour
{
    [SerializeField] private bool isLeftDir = true;
    [SerializeField] private Sprite yakiGyouza;
    [SerializeField, Range(0.0f, 10.0f)] private float deleteTime = 1.0f;
    [SerializeField,Range(0.0f,10.0f)] private float power = 1.0f;
    [SerializeField,Range(0,10)] private float randomPower = 0;
    private bool isCombination = false; // 皮と肉だねが合体したらtrue
    private float time = 0.0f; // 合体してからの時間
    // Start is called before the first frame update
    void Start()
    {
        power *= Random.Range(1.0f - randomPower / 10.0f, 1.0f + randomPower / 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // 合体したら移動しない
        if (isCombination)
        {
            time += Time.deltaTime;
            if (deleteTime < time)
            {
                Destroy(this.gameObject);
            }
            return;
        }

        // 左方向に飛ばす場合
        if (isLeftDir)
        {
            MoveLeft();
            return;
        }

        // 右方向に飛ばす場合
        MoveRight();
    }

    void MoveLeft()
    {
        this.transform.Translate(-power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    void MoveRight()
    {
        this.transform.Translate(power * 3.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GyouzaKawaDestroyer"))
        {
            Destroy(this.gameObject);
        }

        if (collision.CompareTag("Meet"))
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
