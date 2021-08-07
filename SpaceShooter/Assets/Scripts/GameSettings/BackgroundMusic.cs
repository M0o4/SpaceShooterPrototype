using GameUI;
using UnityEngine;

namespace GameSettings
{
    public class BackgroundMusic : MonoBehaviour
    {
        private AudioSource _audio;

        private void Start()
        {
            _audio = GetComponent<AudioSource>();
            GameSettings.onGameMusicChanged += OnBGMusicChange;
            _audio.mute = !GameSettings.GameMusic;
        }

        private void Update()
        {
            _audio.pitch = PauseMenuUI.IsGamePaused ? 0.5f : 1f;
        }
        
        private void OnBGMusicChange()
        {
            _audio.mute = !GameSettings.GameMusic;
        }

        private void OnDestroy()
        {
            GameSettings.onGameMusicChanged -= OnBGMusicChange;
        }
    }
}
