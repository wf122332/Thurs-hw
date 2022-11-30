using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{

    public class FireSystembase : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;
        [SerializeField, Header("�o�g����")]
        private AudioClip soundFire;

        //�ۭq��k
        //�ͦ��l�u
        //protected �O�@�ŧO:���\�l���O�s��
        protected void SpawnBullet()
        {
            //��Ҥ�(����,�y��,����)
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            SoundManager.instance.Playsound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}
