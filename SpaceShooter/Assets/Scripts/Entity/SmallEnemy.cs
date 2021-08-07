using Character;
using PoolObject;
using UnityEngine;

namespace Entity
{
    public class SmallEnemy : Enemy, IDamageable
    {
        public EnemyMovement EnemyMovement => _enemyMovement;
        public ShootWeapon ShootWeapon => _shootWeapon;
        
        [SerializeField] private GameObject _explosionPrefab;
        private PoolObject.PoolObject _poolObject;
        private EnemyMovement _enemyMovement;
        private ShootWeapon _shootWeapon;
        private int _currentHealth;


        private void Start()
        {
            _poolObject = GetComponent<PoolObject.PoolObject>();
            _enemyMovement = GetComponent<EnemyMovement>();
            _shootWeapon = GetComponent<ShootWeapon>();
            _currentHealth = Health;
        }
        

        public void GetDamage(int damage)
        {
            if (IsDamageable())
                _currentHealth -= damage;
            else
                Die();
        }

        public bool IsDamageable() => _currentHealth > 0;

        public void SetHealth()
        {
            _currentHealth = Health;
        }

        private void Die()
        {
            _enemyMovement.StopMovement(Vector3.zero);
            _shootWeapon.StopCoroutine();
            PlayerScore.IncreaseScore();
            var spawnPoint = transform;
            PoolManager.GetObject(_explosionPrefab.name, spawnPoint.position, spawnPoint.rotation);
            _poolObject.ReturnToPool();
        }
    }
}
