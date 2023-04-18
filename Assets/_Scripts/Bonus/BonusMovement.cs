using UnityEngine;

namespace Evstr
{
    public class BonusMovement : MonoBehaviour
    {
        private float _speed = 2.0f;

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
