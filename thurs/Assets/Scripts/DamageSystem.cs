using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [Header("受傷及爆炸音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;


        private void OnCollisionEnter2D(Collision2D collision)
        {
            //如果 踫到物件的名稱 就爆炸
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.Playsound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.Playsound(soundExplosion, new Vector2(1.2f, 1.5f));
    
            //刪除物件
                Destroy(gameObject);
            }
        }
    }
}
