using UnityEngine;

namespace Entity
{
    public class Enemy : MonoBehaviour
    {
        protected int Health => _health;
        public int Damage => _damage;
        
        [SerializeField] private int _health;
        [SerializeField] private int _damage;
    }
}
