using PoolObject;
using UnityEngine;

namespace Character
{
    public class LaserBolt : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _explosionParticle;
        [SerializeField] private Transform _attackPoint;
        [SerializeField] private LayerMask _enemyLayers;
        [SerializeField] private float _attackRange;
        [SerializeField] private int _attackDamage;
        private PoolObject.PoolObject _poolObject;
        private BoltMovement _boltMovement;

        private void Start()
        {
            _boltMovement = GetComponent<BoltMovement>();
            _poolObject = GetComponent<PoolObject.PoolObject>();
        }

        private void Update()
        {
            Shoot();
        }

        private void Shoot()
        {
            if(!_attackPoint) return;
            
            var hitEnemies = Physics2D.OverlapCircleAll(_attackPoint.position, _attackRange, _enemyLayers);

            foreach (var enemy in hitEnemies)
            {
                PoolManager.GetObject(_explosionParticle.name, transform.position,Quaternion.identity);
                enemy.GetComponent<IDamageable>().GetDamage(_attackDamage);
                _boltMovement.ResetLifeTime();
                _poolObject.ReturnToPool();
            }
        }
        
          
        private void OnDrawGizmosSelected()
        {
            if(_attackPoint == null)
                return;
      
            Gizmos.DrawWireSphere(_attackPoint.position, _attackRange);
        }
    }
}
