using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Background
{
    public class BackgroundLoop : MonoBehaviour
    {
        private float _speed = 5f;

        private void Update()
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
            if (transform.position.y < -12.5f)
            {
                transform.position = new Vector2(-2.45f, 12.5f);
            }
        }
    }
}
