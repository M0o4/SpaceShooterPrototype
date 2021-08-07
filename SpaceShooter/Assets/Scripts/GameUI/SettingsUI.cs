using UnityEngine;
using UnityEngine.EventSystems;

namespace GameUI
{
    public class SettingsUI : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private GameObject _settingsUI;
        private bool _isActive;
    
        public void OnPointerClick(PointerEventData eventData)
        {
            OpenCloseSettings();
        }
    
        private void OpenCloseSettings()
        {
            _isActive = !_isActive;
            PauseMenuUI.PauseResumeGame();
            _settingsUI.SetActive(_isActive);
        }
    }
}
