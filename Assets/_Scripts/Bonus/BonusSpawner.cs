using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr
{
    public class BonusSpawner : MonoBehaviour
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
                _timeIndex = Random.Range(5, 10);
                yield return new WaitForSeconds(_timeIndex);
                GameObject bonus = ObjectPool.SharedInstance.GetPooledObjectBonus();
                _xPosition = Random.Range(-_xBoards, _xBoards);
                if (bonus != null)
                {
                    bonus.transform.position = new Vector2(_xPosition, _yPosition);
                    bonus.SetActive(true);
                }
            }
        }
    }
}
