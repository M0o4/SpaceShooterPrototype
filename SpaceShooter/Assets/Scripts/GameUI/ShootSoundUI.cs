using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameUI
{
    public class ShootSoundUI : ButtonUI, IPointerClickHandler
    {
        private bool _isActive;

        private void Start()
        {
            Image = GetComponent<Image>();
            _isActive = GameSettings.GameSettings.ShootSound;
            SetImageColor(_isActive);
        }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            _isActive = !_isActive;
            OffOnSetting(_isActive);
        }

        protected override void OffOnSetting(bool isActive)
        {
            base.OffOnSetting(_isActive);
            GameSettings.GameSettings.ShootSound = _isActive;
            GameSettings.GameSettings.ShootSoundChanged();
        }
    }
}
