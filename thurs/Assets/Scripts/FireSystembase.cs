using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSystembase : MonoBehaviour
{
    [SerializeField, Header("�l�u�w�s��")]
    private GameObject prefabBullet;
    [SerializeField, Header("�l�u�ͦ��I")]
    private Transform pointSpawn;

    //�ۭq��k
    //�ͦ��l�u
    //protected �O�@�ŧO:���\�l���O�s��
    protected void SpawnBullet()
    {
        //��Ҥ�(����,�y��,����)
        Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
    }
}
