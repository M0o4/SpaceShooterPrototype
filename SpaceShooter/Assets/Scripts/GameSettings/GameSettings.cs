using System;

namespace GameSettings
{
    public static class GameSettings
    {
        public static float Sensitivity = 0.5f;
        public static bool GameMusic = true;
        public static bool ShootSound = true;

        public static event Action onGameMusicChanged;
        public static void GameMusicChanged()
        {
            onGameMusicChanged?.Invoke();
        }
        public static event Action onShootSoundChanged;
        public static void ShootSoundChanged()
        {
            onShootSoundChanged?.Invoke();
        }
        public static event Action onSensitivityChanged;
        public static void SensitivityChanged()
        {
            onSensitivityChanged?.Invoke();
        }
    }
}
