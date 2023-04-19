using UnityEngine;
using Evstr.Score;

namespace Evstr.Rocket
{
    public class RocketDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _plus10;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                gameObject.SetActive(false);
                collision.gameObject.SetActive(false);
                Instantiate(_plus10);
                ScoreIncrease.score += 10;
            }
        }
    }
}
