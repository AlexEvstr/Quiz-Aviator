using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Rocket
{
    public class RocketDetector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                gameObject.SetActive(false);
                collision.gameObject.SetActive(false);
            }
        }
    }
}
