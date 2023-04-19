using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Evstr.GUI
{
    public class UIStartButton : UIBaseButton
    {
        [SerializeField] private Text _lastScoreText;
        private float _lastScore;

        private void Start()
        {
            _lastScore = PlayerPrefs.GetInt("Last Score");
            _lastScoreText.text = _lastScore.ToString();
        }

        public override void OnClick()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
    }
}
