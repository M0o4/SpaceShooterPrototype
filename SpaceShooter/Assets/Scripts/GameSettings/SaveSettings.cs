using System;
using Character;
using UnityEngine;

namespace GameSettings
{
    public class SaveSettings : MonoBehaviour
    {
        private void Start()
        {
            GameSettings.onGameMusicChanged += OnBGMusicChange;
            GameSettings.onShootSoundChanged += OnShootSoundChange;
            GameSettings.onSensitivityChanged += OnSensitivityChanged;
        }
        
        private void OnBGMusicChange()
        {
            PlayerPrefs.SetInt(nameof(GameSettings.GameMusic), Utils.BoolToInt(GameSettings.GameMusic));
        }

        private void OnShootSoundChange()
        {
            PlayerPrefs.SetInt(nameof(GameSettings.ShootSound), Utils.BoolToInt(GameSettings.ShootSound));
        }

        private void OnSensitivityChanged()
        {
            PlayerPrefs.SetFloat(nameof(GameSettings.Sensitivity),GameSettings.Sensitivity);
        }

      
        private void OnDestroy()
        {
            GameSettings.onGameMusicChanged -= OnBGMusicChange;
            GameSettings.onShootSoundChanged -= OnShootSoundChange;
            GameSettings.onSensitivityChanged -= OnSensitivityChanged;
        }
    }
}
