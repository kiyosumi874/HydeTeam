using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatDestroy : MonoBehaviour
{
    //•Ï”éŒ¾
    const float ScreenHeight = -5.0f; //‰æ–Ê‚Ì‚‚³

    // Update is called once per frame
    void Update()
    {
        //‰æ–ÊŠO‚Éo‚½‚çíœ‚·‚é
        if (transform.position.y <= ScreenHeight)
        {
            Destroy(gameObject);
        }
    }
}
