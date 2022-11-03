using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSystembase : MonoBehaviour
{
    [SerializeField, Header("子彈預製物")]
    private GameObject prefabBullet;
    [SerializeField, Header("子彈生成點")]
    private Transform pointSpawn;

    //自訂方法
    //生成子彈
    //protected 保護級別:允許子類別存取
    protected void SpawnBullet()
    {
        //實例化(物件,座標,角度)
        Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
    }
}
