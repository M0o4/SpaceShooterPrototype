using System;
using Character;
using TMPro;
using UnityEngine;

namespace GameUI
{
    public class GameOverUI : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverPanel;
        [SerializeField] private TextMeshProUGUI _bestScoreText;
        
        private void Start()
        {
            GameOverScreen.onGaveOver += ShowGameOverScreen;
        }

        private void ShowGameOverScreen()
        {
            PauseMenuUI.PauseResumeGame();
            _gameOverPanel.SetActive(true);
            if (PlayerScore.BestScore > 0)
            {
                _bestScoreText.gameObject.SetActive(true);
                _bestScoreText.text = $"Best Score: {PlayerScore.BestScore}";
            }
        }

        private void OnDestroy()
        {
            GameOverScreen.onGaveOver -= ShowGameOverScreen;
        }
    }
}
