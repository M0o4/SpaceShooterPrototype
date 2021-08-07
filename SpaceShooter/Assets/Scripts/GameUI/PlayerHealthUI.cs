using Character;
using TMPro;
using UnityEngine;

namespace GameUI
{
    public class PlayerHealthUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _healthText;
        private SpaceShip _spaceShip;
        private int _oldHealth;

        private void Start()
        {
            _spaceShip = FindObjectOfType<SpaceShip>();
            _oldHealth = _spaceShip.Health;
        }

        private void Update()
        {
            if (_oldHealth != _spaceShip.CurrentHealth)
            {
                _healthText.text = $"Health: {_spaceShip.CurrentHealth}/{_spaceShip.Health}";
                _oldHealth = _spaceShip.CurrentHealth;
            }
        }
    }
}
