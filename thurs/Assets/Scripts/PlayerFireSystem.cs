using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{
    /// <summary>
    /// ���a�o�g
    /// </summary>

    public class PlayerFireSystem : FireSystembase
    {
        private void Update()
        {
            //press"space"> make bullet
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}
