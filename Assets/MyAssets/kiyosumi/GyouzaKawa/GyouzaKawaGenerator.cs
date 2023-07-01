using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 餃子の皮達を生成するクラス
/// </summary>
public class GyouzaKawaGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> gyouzaKawaPrefabs; // 餃子の皮達のプレハブ
    private int prefabIndex; // gyouzaKawaPrefabsの添え字
    private int prefabSize; // gyouzaKawaPrefabsの中のPrefabの数

    private float nowTime; // nowTimeが初期化されてから経過した時間
    private float instantiateTime; // 次に新しい餃子の皮が生成されるまでの時間
    private float spriteChangeSpan;//spriteの変更するタイミング
    [SerializeField] private List<string> stringPrefab;
    [SerializeField] private Text text;
    [SerializeField] private float randTimeMax = 6.0f; // nextTimeのランダム値の最大値
    [SerializeField] private float randTimeMin = 3.0f; // nextTimeのランダム値の最小値

    /// <summary>
    /// このクラスが生成されたとき最初に一回呼び出される関数
    /// </summary>
    void Start()
    {
        nowTime = 0.0f;
        instantiateTime = Random.Range(randTimeMin, randTimeMax);
        prefabSize = gyouzaKawaPrefabs.Count;
        prefabIndex = Random.Range(0, prefabSize);
        spriteChangeSpan = instantiateTime / stringPrefab.Count;
    }

    /// <summary>
    /// 更新
    /// </summary>
    void Update()
    {
        if (CheckIsInstantiate())
        {
            // 餃子の皮Prefabを生成
            Instantiate(gyouzaKawaPrefabs[prefabIndex], this.transform);
            CleanUpAfterInstantiate();
        }
        ChangeString();
        // 時間を進める
        nowTime += Time.deltaTime;
    }

    /// <summary>
    /// 時間や餃子の皮Prefabの添え字を初期化
    /// </summary>
    private void CleanUpAfterInstantiate()
    {
        nowTime = 0.0f;
        instantiateTime = Random.Range(randTimeMin, randTimeMax);
        prefabIndex = Random.Range(0, prefabSize);
        spriteChangeSpan = instantiateTime / stringPrefab.Count;
    }

    /// <summary>
    /// 新しい餃子の皮を生成できるかチェック
    /// </summary>
    /// <returns>生成できるならtrue</returns>
    private bool CheckIsInstantiate()
    {
        return nowTime > instantiateTime;
    }
    /// <summary>
    /// 皮を出す予兆を見せる
    /// </summary>
    private void ChangeString()
    {
        int stringIndex = (int)(nowTime/ spriteChangeSpan);
        text.text = stringPrefab[stringIndex];
    }
}
