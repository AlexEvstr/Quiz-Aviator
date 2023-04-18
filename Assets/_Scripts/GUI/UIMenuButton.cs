using UnityEngine.SceneManagement;

namespace Evstr.GUI
{
    public class UIMenuButton : UIBaseButton
    {
        public override void OnClick()
        {
            SceneManager.LoadScene(0);
        }
    }
}
