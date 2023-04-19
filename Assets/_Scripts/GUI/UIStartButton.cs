using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Evstr.GUI
{
    public class UIStartButton : UIBaseButton
    {
        public override void OnClick()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
    }
}
