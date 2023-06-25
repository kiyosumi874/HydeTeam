using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result_Gyouza : MonoBehaviour
{
    public GameObject gyouzaYaki;
    public Transform createPosition;
    public int gyouzaNum;
    private int nouCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //gyouzaNum = GyouzaCounter.Get();
    }

    // Update is called once per frame
    void Update()
    {
        if(nouCount <= gyouzaNum)
        {
            Instantiate(gyouzaYaki, createPosition);
            nouCount++;
        }
    }
}
