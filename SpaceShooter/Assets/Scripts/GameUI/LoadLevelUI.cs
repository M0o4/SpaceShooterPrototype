using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace GameUI
{
    public class LoadLevelUI : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] [Min(0)] private int _sceneIndex;
        
        public void OnPointerClick(PointerEventData eventData)
        {
            SceneManager.LoadSceneAsync(_sceneIndex);
        }
    }
}
