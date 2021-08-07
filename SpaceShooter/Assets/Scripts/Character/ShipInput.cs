using UnityEngine;
using UnityEngine.InputSystem;

namespace Character
{
    [RequireComponent(typeof(Movement), typeof(PlayerInput))]
    public class ShipInput : MonoBehaviour
    {
        private Movement _movement;
        private PlayerInput _playerInput;
        private Vector2 _input;

        private void Start()
        {
            _movement = GetComponent<Movement>();
            _playerInput = GetComponent<PlayerInput>();
        }

        private void Update()
        {
            ProcessInput();
            Move();
        }

        private void ProcessInput()
        {
            _input = _playerInput.actions["Move"].ReadValue<Vector2>();
        }

        private void Move()
        {
            _movement.Move(_input);
        }
        
    }
}
