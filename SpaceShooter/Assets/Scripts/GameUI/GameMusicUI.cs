using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameUI
{
    public class GameMusicUI : ButtonUI, IPointerClickHandler
    {
        private bool _isActive;
        
        private void Start()
        {
            Image = GetComponent<Image>();
            _isActive = GameSettings.GameSettings.GameMusic;
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
            GameSettings.GameSettings.GameMusic = _isActive;
            GameSettings.GameSettings.GameMusicChanged();
        }
    }
}
