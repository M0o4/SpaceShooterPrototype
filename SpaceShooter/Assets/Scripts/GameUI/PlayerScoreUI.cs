using Character;
using TMPro;
using UnityEngine;

namespace GameUI
{
    public class PlayerScoreUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;
        private int _oldScore;
        
        private void Update()
        {
            if (_oldScore != PlayerScore.Score)
            {
                _scoreText.text = $"Score: {PlayerScore.Score}";
                _oldScore = PlayerScore.Score;
            }
        }
    }
}
