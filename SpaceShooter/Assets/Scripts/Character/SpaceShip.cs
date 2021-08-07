using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Character
{
    public class SpaceShip : MonoBehaviour, IDamageable
    {
        public int Health => _health;
        public int CurrentHealth => _currentHealth;
        
        [SerializeField] private int _health;
        private int _currentHealth;

        private void Start()
        {
            _currentHealth = _health;
        }

        public void GetDamage(int damage)
        {
            if (IsDamageable())
            {
                _currentHealth -= damage;
                if (_currentHealth <= 0)
                   Die();
            }
        }
        
        public bool IsDamageable() => _currentHealth > 0;

        private void Die()
        {
            GameOverScreen.GameOver();
            gameObject.SetActive(false);
        }
    }
}
