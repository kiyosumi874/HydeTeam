using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyouzaCounter
{
    static private  int count = 0;

    static public void Count()
    {
        count++;
    }

    static public int Get()
    {
        return count;
    }
}
