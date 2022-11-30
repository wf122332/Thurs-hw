using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{
    /// <summary>
    /// �ˮ`�t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z���w�s��")]
        private GameObject prefabExplosion;
        [Header("���ˤ��z������")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;


        private void OnCollisionEnter2D(Collision2D collision)
        {
            //�p�G ��쪫�󪺦W�� �N�z��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.Playsound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.Playsound(soundExplosion, new Vector2(1.2f, 1.5f));
    
            //�R������
                Destroy(gameObject);
            }
        }
    }
}
