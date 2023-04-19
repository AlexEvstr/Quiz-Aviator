using UnityEngine.SceneManagement;
using UnityEngine;
using Evstr.Score;

namespace Evstr.GUI
{
    public class UIMenuButton : UIBaseButton
    {
        public override void OnClick()
        {
            SceneManager.LoadScene(0);
        }

        private void OnDisable()
        {
            PlayerPrefs.SetInt("Last Score", ScoreIncrease.score);
        }
    }
}
