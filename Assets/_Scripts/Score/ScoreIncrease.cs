using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.Score
{
    public class ScoreIncrease : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;
        public static int score;

        private void Start()
        {
            score = 0;
            StartCoroutine(IncreaseScore());
        }

        private IEnumerator IncreaseScore()
        {
            while (true)
            {
                score++;
                yield return new WaitForSeconds(1.0f);
            }
        }

        private void Update()
        {
            _scoreText.text = score.ToString();
        }
    }
}
