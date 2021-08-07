using System;
using Character;
using UnityEngine;

namespace PlayerStats
{
    public class SavePlayerStats : MonoBehaviour
    {
        private void Start()
        {
            GameOverScreen.onGaveOver += OnGameOver;
        }

        private void OnGameOver()
        {
            if (PlayerScore.Score > PlayerScore.BestScore)
            {
                PlayerPrefs.SetInt(nameof(PlayerScore.BestScore), PlayerScore.Score);
            }
        }

        private void OnDestroy()
        {
            GameOverScreen.onGaveOver -= OnGameOver;
        }
    }
}
