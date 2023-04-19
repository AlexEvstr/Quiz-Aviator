using UnityEngine;

namespace Evstr.GUI
{
    public class UIFalseButton : UIBaseButton
    {
        [SerializeField] private GameObject _taskPanel;
        [SerializeField] private GameObject _gameOverPanel;

        public override void OnClick()
        {
            _taskPanel.SetActive(false);
            _gameOverPanel.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
