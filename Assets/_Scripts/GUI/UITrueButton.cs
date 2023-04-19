using UnityEngine;
using Evstr.Score;


namespace Evstr.GUI
{
    public class UITrueButton : UIBaseButton
    {
        [SerializeField] private GameObject _taskPanel;
        [SerializeField] private GameObject _plus100;

        public override void OnClick()
        {
            _taskPanel.SetActive(false);
            Time.timeScale = 1;
            Instantiate(_plus100);
            ScoreIncrease.score += 100;

        }
    }
}
