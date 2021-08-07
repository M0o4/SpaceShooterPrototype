using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Development
{
    public class TouchDebug : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _touchDebugText;
        private PlayerInput _playerInput;
        private Vector2 _input;
        private Vector2 _oldInput;

        private void Start()
        {
            _playerInput = FindObjectOfType<PlayerInput>();
        }

        private void Update()
        {
            _input = _playerInput.actions["Move"].ReadValue<Vector2>();
            if (_oldInput != _input)
            {
                _touchDebugText.text = $"Input: {_input}";
                _oldInput = _input;
            }
        }
    }
}
