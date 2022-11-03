using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ĤH�o�g
/// </summary>
public class EnemyFireSystem : FireSystembase
{
    [SerializeField, Header("�ͦ����j"), Range(0, 3)]
    private float interval = 1.5f;

    private void Awake()
    {
        //���𭫽ƩI�s(��k�W��,����ɶ�,���j)
        InvokeRepeating("SpawnBullet", 0, interval);
    }
}
