using System;
using Character;
using UnityEngine;

namespace PlayerStats
{
    public class LoadPlayerStats : MonoBehaviour
    {
        private void Awake()
        {
            LoadStatsFromPlayerPrefs();
        }

        private void LoadStatsFromPlayerPrefs()
        {
            PlayerScore.BestScore = PlayerPrefs.GetInt(nameof(PlayerScore.BestScore)); 
        }
    }
}
