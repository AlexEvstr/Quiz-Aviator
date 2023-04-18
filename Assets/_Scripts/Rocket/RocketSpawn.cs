using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Rocket
{
    public class RocketSpawn : MonoBehaviour
    {
        [SerializeField] private GameObject _player;

        private void Start()
        {
            StartCoroutine(SpawnRocket());
        }

        public IEnumerator SpawnRocket()
        {
           while(true)
            {
                yield return new WaitForSeconds(1f);
                GameObject rocket = ObjectPool.SharedInstance.GetPooledObjectRocket();

                if (rocket != null)
                {
                    rocket.transform.position = new Vector2(_player.transform.position.x,
                                                _player.transform.position.y);
                    rocket.SetActive(true);
                }
            }
        }
    }
}
