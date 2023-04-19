using UnityEngine;
using UnityEngine.UI;

namespace Evstr.Score
{
    public class BestScore : MonoBehaviour
    {
        [SerializeField] private Text _bestScoreText;
        private int _bestScore;

        private void Start()
        {
            _bestScore = PlayerPrefs.GetInt("Best Score");
            _bestScoreText.text = _bestScore.ToString();
        }

        private void Update()
        {
            if (_bestScore < ScoreIncrease.score)
            {
                _bestScore = ScoreIncrease.score;
                _bestScoreText.text = _bestScore.ToString();
            }
        }

        private void OnDisable()
        {
            PlayerPrefs.SetInt("Best Score", _bestScore);
        }
    }
}
