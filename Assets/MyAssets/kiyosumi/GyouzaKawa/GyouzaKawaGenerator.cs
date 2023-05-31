using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyouzaKawaGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> gyouzaKawaPrefabs;
    private float nowTime;
    private float nextTime;
    private int prefabIndex;
    private int prefabSize;
    [SerializeField] private float randTimeMax = 6.0f;
    [SerializeField] private float randTimeMin = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        nowTime = 0.0f;
        nextTime = Random.Range(randTimeMin, randTimeMax);
        prefabSize = gyouzaKawaPrefabs.Count;
        prefabIndex = Random.Range(0, prefabSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (nowTime > nextTime)
        {
            nowTime = 0.0f;
            nextTime = Random.Range(randTimeMin, randTimeMax);
            Instantiate(gyouzaKawaPrefabs[prefabIndex], this.transform);
            prefabIndex = Random.Range(0, prefabSize);
        }
        nowTime += Time.deltaTime;
    }
}
