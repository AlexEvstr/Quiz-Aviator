using UnityEngine;

namespace Evstr.Player
{
    public class Detector : MonoBehaviour
    {
        [SerializeField] private TaskManager _taskManager;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Game Over");
            }
            else if (collision.gameObject.CompareTag("Bonus"))
            {
                collision.gameObject.SetActive(false);
                Time.timeScale = 0;
                _taskManager.SetNewTask();

            }
        }
    }
}
