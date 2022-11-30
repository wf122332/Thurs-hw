using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{

    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            FinalManager.instance.GameOver("�D�ԥ���");
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            FinalManager.instance.GameOver("�C���q�L");
        }
    }
}
