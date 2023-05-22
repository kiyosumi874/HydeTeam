using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GyouzaKawaMove0 : MonoBehaviour
{
    [SerializeField] private bool isLeftDir = true;
    [SerializeField,Range(0.0f,10.0f)] private float power = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
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
        this.transform.Translate(-power / 100.0f, 0.0f, 0.0f);
    }

    void MoveRight()
    {
        this.transform.Translate(power / 100.0f, 0.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GyouzaKawaDestroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}
