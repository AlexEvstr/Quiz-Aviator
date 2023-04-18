using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Player
{
    public class Detector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Game Over");
            }
            else if (collision.gameObject.CompareTag("Bonus"))
            {
                collision.gameObject.SetActive(false);
                Debug.Log("Open Task");
            }
        }
    }
}
