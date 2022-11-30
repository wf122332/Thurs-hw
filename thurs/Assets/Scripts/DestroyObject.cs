using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{
    /// <summary>
    /// 刪除物件
    /// </summary>

    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            Destroy(gameObject, destroyTime);
        }

        
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}