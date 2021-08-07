using UnityEngine;

namespace Character
{
    public class BoltMovement : MonoBehaviour
    {
        private PoolObject.PoolObject _poolObject;
        [SerializeField] private float _speed;
        [SerializeField] private float _lifeTime;
        private float _currentLifeTime;


        private void Start()
        {
            _poolObject = GetComponent<PoolObject.PoolObject>();
            ResetLifeTime();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (_currentLifeTime <= 0)
            {
                _poolObject.ReturnToPool();
                ResetLifeTime();

            } else
            {
                transform.Translate(new Vector3(0f,_speed * Time.deltaTime,0f));
                _currentLifeTime -= Time.deltaTime;
            }
        }

        public void ResetLifeTime()
        {
            _currentLifeTime = _lifeTime;
        }
    }
}
