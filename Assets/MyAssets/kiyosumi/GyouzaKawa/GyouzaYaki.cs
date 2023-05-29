using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyouzaYaki : MonoBehaviour
{
    [SerializeField] private float time = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
