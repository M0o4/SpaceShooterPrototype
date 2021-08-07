using System;
using System.Collections;
using Character;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameUI
{
    public class StartGameUI : MonoBehaviour,IPointerClickHandler
    {
        private TransitionUI _transition;
        [SerializeField] private int _sceneIndex;
        private GameObject _ship;
        private float _boundaryY;
        private bool _isButtonPressed;

        private void Start()
        {
            Vector2 worldBoundary = Camera.main.ScreenToWorldPoint( new Vector2( Screen.width, Screen.height ));
            _boundaryY = worldBoundary.y;
            
            _ship = FindObjectOfType<SpaceShip>().gameObject;
            _transition = FindObjectOfType<TransitionUI>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if(!_isButtonPressed)
                StartCoroutine(LoadGame());
        }

        IEnumerator LoadGame()
        {
            _isButtonPressed = true;
            yield return StartCoroutine(MoveShip());
            SceneManager.LoadSceneAsync(_sceneIndex);
        }

        IEnumerator MoveShip()
        {
            _transition.EndAnimation();
            var startPosition = _ship.transform.position;
            for (float i = 0; i < 1; i += Time.deltaTime)
            {
                _ship.transform.position = Vector3.Lerp(startPosition, new Vector3(startPosition.x,_boundaryY +1f,0f), Easing.EaseOutSine(i));
                yield return null;
            }
        }
    }
}
