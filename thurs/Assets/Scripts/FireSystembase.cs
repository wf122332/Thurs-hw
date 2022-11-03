using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSystembase : MonoBehaviour
{
    [SerializeField, Header("�l�u�w�s��")]
    private GameObject prefabBullet;
    [SerializeField, Header("�l�u�ͦ��I")]
    private Transform pointSpawn;

    protected void SpawnBullet()
    {
        Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);


    }
}
