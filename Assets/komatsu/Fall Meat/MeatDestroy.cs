using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatDestroy : MonoBehaviour
{
    //�ϐ��錾
    const float ScreenHeight = -5.0f; //��ʂ̍���

    // Update is called once per frame
    void Update()
    {
        //��ʊO�ɏo����폜����
        if (transform.position.y <= ScreenHeight)
        {
            Destroy(gameObject);
        }
    }
}
