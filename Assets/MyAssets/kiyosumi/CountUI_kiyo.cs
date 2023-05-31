using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 餃子を何個作れたか表示する仮クラス
/// </summary>
public class CountUI_kiyo : MonoBehaviour
{
    // 更新
    void Update()
    {
        GetComponent<Text>().text = GyouzaCounter.Get().ToString();
    }
}
