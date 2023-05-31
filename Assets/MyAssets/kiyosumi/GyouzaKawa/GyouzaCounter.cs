using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 餃子を作った数を数えたり取得する静的クラス
/// </summary>
public class GyouzaCounter
{
    static private int count = 0; // 餃子を作った数

    // 作った餃子の数を1つ増やす
    static public void Count()
    {
        count++;
    }

    // 作った餃子の数を取得する
    static public int Get()
    {
        return count;
    }
}
