using System;
using System.Collections;
using UnityEngine;

namespace Entity
{
    public class EnemyMovement : MonoBehaviour
    {
        private PoolObject.PoolObject _poolObject;
        [SerializeField] private float _moveTime;
        private Vector3 _targetPosition;
        private float _bottomScreen;
        private bool _isCoroutineStart;

        private void Start()
        {
            _poolObject = GetComponent<PoolObject.PoolObject>();
            _bottomScreen = -Utils.GetWorldBoundary().y;
            var position = transform.position;
            _targetPosition = new Vector3(position.x, _bottomScreen - 1f, 0f);
        }
        
        IEnumerator MoveCoroutine(Vector3 startPosition)
        {
            for (float i = 0; i < 1; i += Time.deltaTime / _moveTime)
            {
                transform.position = Vector3.Lerp(startPosition, _targetPosition, Easing.EaseOutSine(i));

                yield return null;
            }

            _poolObject.ReturnToPool();
        }

        public void StartMovement(Vector3 startPosition)
        {
            StartCoroutine(MoveCoroutine(startPosition));
        }
        
        public void StopMovement(Vector3 startPosition)
        {
            StopCoroutine(MoveCoroutine(startPosition));
        }
    }
}
