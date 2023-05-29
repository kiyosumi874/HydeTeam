using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GyouzaKawaMove0 : MonoBehaviour
{
    [SerializeField] private bool isLeftDir = true;
    [SerializeField] private GameObject gyouzaPrefab;
    [SerializeField,Range(0.0f,10.0f)] private float power = 1.0f;
    [SerializeField,Range(0,10)] private float randomPower = 0;
    // Start is called before the first frame update
    void Start()
    {
        power *= Random.Range(1.0f - randomPower / 10.0f, 1.0f + randomPower / 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // ç∂ï˚å¸Ç…îÚÇŒÇ∑èÍçá
        if (isLeftDir)
        {
            MoveLeft();
            return;
        }

        // âEï˚å¸Ç…îÚÇŒÇ∑èÍçá
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
            Instantiate(gyouzaPrefab, this.gameObject.transform);
            //Destroy(this.gameObject);
        }
    }
}
