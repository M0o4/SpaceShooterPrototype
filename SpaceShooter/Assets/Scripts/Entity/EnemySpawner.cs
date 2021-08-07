using System.Collections;
using Character;
using PoolObject;
using UnityEngine;

namespace Entity
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyPrefab;
        [SerializeField] private float _timeToSpawn;
        private float _boundaryX, _boundaryY;
        private WaitForSeconds _waitToSpawn;

        private void Start()
        {
            var worldBoundary = Utils.GetWorldBoundary();
            _boundaryX = worldBoundary.x-1f;
            _boundaryY = worldBoundary.y;
            _waitToSpawn = new WaitForSeconds(_timeToSpawn);
            StartCoroutine(WaitToSpawn());
        }

        private IEnumerator WaitToSpawn()
        {
            yield return new WaitForSeconds(1f);
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                var spawnPoint = Random.Range(_boundaryX, -_boundaryX);
                var enemy= PoolManager.GetObject(_enemyPrefab.name, new Vector3(spawnPoint,_boundaryY +1f,0f), transform.rotation);
                enemy.GetComponent<EnemyMovement>().StartMovement(enemy.transform.position);
                enemy.GetComponent<ShootWeapon>().StartCoroutine();
                enemy.GetComponent<SmallEnemy>().SetHealth();
                yield return _waitToSpawn;
            }
        }
        
    }
}
