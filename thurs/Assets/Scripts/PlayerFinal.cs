using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{

    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            FinalManager.instance.GameOver("挑戰失敗");
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            FinalManager.instance.GameOver("遊戲通過");
        }
    }
}
