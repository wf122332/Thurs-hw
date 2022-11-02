using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            transform.Translate(speed*Time.deltaTime, 0, 0);
        }



    }

}
