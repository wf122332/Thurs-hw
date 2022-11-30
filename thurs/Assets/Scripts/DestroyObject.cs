using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{
    /// <summary>
    /// �R������
    /// </summary>

    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("�R���ɶ�"), Range(0, 3)]
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