using Character;
using GameUI;
using UnityEngine;

namespace GameSettings
{
    public class StartGame : MonoBehaviour
    {
        private void Start()
        {
            if(PauseMenuUI.IsGamePaused)
                PauseMenuUI.PauseResumeGame();
            PlayerScore.ResetScore();
        }
    }
}
