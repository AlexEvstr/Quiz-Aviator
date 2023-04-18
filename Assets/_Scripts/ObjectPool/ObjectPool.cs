using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr
{
    public class ObjectPool : MonoBehaviour
    {
        public static ObjectPool SharedInstance;
        public List<GameObject> objectToPool;

        public List<GameObject> pooledBonus;
        public List<GameObject> pooledEnemies;
        public List<GameObject> pooledRockets;

        public int amountToPoolBonus;
        public int amountToPoolEnemy;
        public int amountToPoolRocket;

        private void Awake()
        {
            SharedInstance = this;
        }

        private void Start()
        {
            PoolObjects();
        }

        private void PoolObjects()
        {
            PoolBonus();
            PoolEnemy();
            PoolRocket();
        }

        public GameObject GetPooledObjectBonus()
        {
            for (int i = 0; i < amountToPoolBonus; i++)
            {
                if (!pooledBonus[i].activeInHierarchy)
                {
                    return pooledBonus[i];
                }
            }
            return null;
        }

        private void PoolBonus()
        {
            pooledBonus = new List<GameObject>();
            GameObject bonus;
            for (int i = 0; i < amountToPoolBonus; i++)
            {
                bonus = Instantiate(objectToPool[0]);
                bonus.SetActive(false);
                pooledBonus.Add(bonus);
            }
        }

        public GameObject GetPooledObjectEnemy()
        {
            for (int i = 0; i < amountToPoolEnemy; i++)
            {
                if (!pooledEnemies[i].activeInHierarchy)
                {
                    return pooledEnemies[i];
                }
            }
            return null;
        }

        private void PoolEnemy()
        {
            pooledEnemies = new List<GameObject>();
            GameObject enemy;
            for (int i = 0; i < amountToPoolEnemy; i++)
            {
                enemy = Instantiate(objectToPool[1]);
                enemy.SetActive(false);
                pooledEnemies.Add(enemy);
            }
        }

        public GameObject GetPooledObjectRocket()
        {
            for (int i = 0; i < amountToPoolRocket; i++)
            {
                if (!pooledRockets[i].activeInHierarchy)
                {
                    return pooledRockets[i];
                }
            }
            return null;
        }

        private void PoolRocket()
        {
            pooledRockets = new List<GameObject>();
            GameObject rocket;
            for (int i = 0; i < amountToPoolRocket; i++)
            {
                rocket = Instantiate(objectToPool[2]);
                rocket.SetActive(false);
                pooledRockets.Add(rocket);
            }
        }
    }
}
