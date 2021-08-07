using UnityEngine;

namespace Character
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private bool _limitMovement;
        [Min(0)] [SerializeField] private float _horizontalLimit;
        [Min(0)] [SerializeField] private float _verticalLimit;

        public void Move(Vector2 input)
        {
            transform.Translate(input * (GameSettings.GameSettings.Sensitivity * Time.deltaTime));
            if(_limitMovement)
                LimitMovement();
        }
        
        private void LimitMovement()
        {
            var position = transform.position;
            position = new Vector3(
                Mathf.Clamp( position.x, -_horizontalLimit, _horizontalLimit),
                Mathf.Clamp( position.y, -_verticalLimit, _verticalLimit),
                position.z
            );
            transform.position = position;
        }
        
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireCube(Vector3.zero, new Vector3(_horizontalLimit*2,_verticalLimit*2));
        }
    }
}
