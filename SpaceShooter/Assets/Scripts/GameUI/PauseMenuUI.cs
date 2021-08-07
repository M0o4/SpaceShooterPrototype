using System;
using UnityEngine;

namespace GameUI
{
    public class PauseMenuUI : MonoBehaviour
    {
        public static bool IsGamePaused;
        
        public static void PauseResumeGame()
        {
            if (IsGamePaused)
                ResumeGame();
            else
                PauseGame();
        }
        
        private static void ResumeGame()
        {
            IsGamePaused = false;
            Time.timeScale = 1f;
        }

        private static void PauseGame()
        {
            IsGamePaused = true;
            Time.timeScale = 0f;
        }
    }
}
