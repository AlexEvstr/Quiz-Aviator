using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr
{
    public class EnemyMovement : MonoBehaviour
    {
        private float _speed = 5.0f;

        private void Update()
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
            if (transform.position.y < -6.0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
