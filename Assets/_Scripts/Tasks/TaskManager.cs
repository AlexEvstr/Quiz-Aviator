using UnityEngine;

namespace Evstr
{
    public class TaskManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] _tasks;

        private int _randomIndex;

        public void SetNewTask()
        {
            _randomIndex = Random.Range(0, _tasks.Length);
            _tasks[_randomIndex].SetActive(true);
        }
    }
}
