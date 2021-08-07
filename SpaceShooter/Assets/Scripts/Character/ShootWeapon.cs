using System;
using System.Collections;
using PoolObject;
using UnityEngine;

namespace Character
{
    public class ShootWeapon : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private AudioSource _shootSound;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private float _timeToShoot;
        private WaitForSeconds _waitToShoot;
        private bool _isShootStart;

        private void Awake()
        {
            _isShootStart = true;
        }

        private void Start()
        {
            _waitToShoot = new WaitForSeconds(_timeToShoot);
            StartCoroutine(Shoot());
        }

        private IEnumerator Shoot()
        {
            while (true)
            {
                if(_shootSound != null && GameSettings.GameSettings.ShootSound)
                    _shootSound.Play();
                PoolManager.GetObject(_bulletPrefab.name, _shootPoint.position, transform.rotation);
                yield return _waitToShoot;
            }
        }

        public void StartCoroutine()
        {
            if (!_isShootStart)
            {
                StartCoroutine(Shoot());
                _isShootStart = true;
            }
        }

        public void StopCoroutine()
        {
            if (_isShootStart)
            {
                StopCoroutine(Shoot());
                _isShootStart = false;
            }
        }
    }
}
