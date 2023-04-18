using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Enemy
{
    public class EnemySpawn : MonoBehaviour
    {
        private float _xPosition;
        private float _yPosition = 6.0f;
        private float _xBoards = 1.0f;
        private float _timeIndex;


        private void Start()
        {
            StartCoroutine(SpawnObstacle());
        }

        private IEnumerator SpawnObstacle()
        {
            while (true)
            {
                _timeIndex = Random.Range(1, 3);
                yield return new WaitForSeconds(_timeIndex);
                GameObject enemy = ObjectPool.SharedInstance.GetPooledObjectEnemy();
                _xPosition = Random.Range(-_xBoards, _xBoards);
                if (enemy != null)
                {
                    enemy.transform.position = new Vector2(_xPosition, _yPosition);
                    enemy.SetActive(true);
                }
            }
        }
    }
}
