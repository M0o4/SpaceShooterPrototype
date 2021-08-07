using UnityEngine;
using UnityEngine.UI;

namespace GameUI
{
    public class ButtonUI : MonoBehaviour
    {
        protected Image Image
        {
            set => _image = value;
        }
        private Image _image;

        protected virtual void OffOnSetting(bool isActive)
        {
            SetImageColor(isActive);
        }

        protected virtual void SetImageColor(bool isActive)
        {
            _image.color = !isActive ? Color.grey : Color.white;
        }
    }
}
