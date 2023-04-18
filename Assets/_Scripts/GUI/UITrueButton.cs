using UnityEngine;


namespace Evstr.GUI
{
    public class UITrueButton : UIBaseButton
    {
        [SerializeField] private GameObject _taskPanel;

        public override void OnClick()
        {
            _taskPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
