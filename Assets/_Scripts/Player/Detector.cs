using UnityEngine;

namespace Evstr.Player
{
    public class Detector : MonoBehaviour
    {
        [SerializeField] private TaskManager _taskManager;
        [SerializeField] private GameObject _gameOverPanel;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                _gameOverPanel.SetActive(true);
                Time.timeScale = 0;
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
