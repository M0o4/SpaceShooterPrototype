using UnityEngine;
using UnityEngine.EventSystems;

namespace GameUI
{
    public class MainMenuSettingsUI : MonoBehaviour,IPointerClickHandler
    {
        [SerializeField] private GameObject _mainMenuUI;
        [SerializeField] private GameObject _settingsUI;
        private static bool _isActive;
    
        public void OnPointerClick(PointerEventData eventData)
        {
            OpenCloseSettings();
        }
    
        private void OpenCloseSettings()
        {
            _isActive = !_isActive;
            _mainMenuUI.SetActive(!_isActive);
            _settingsUI.SetActive(_isActive);
        }
    }
}
