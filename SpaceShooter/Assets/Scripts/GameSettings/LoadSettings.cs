using System;
using Character;
using GameUI;
using UnityEngine;

namespace GameSettings
{
    public class LoadSettings : MonoBehaviour
    {
        private void Awake()
        {
            LoadSettingsFromPlayerPrefs();
        }
        

        private void LoadSettingsFromPlayerPrefs()
        {
            if(PlayerPrefs.HasKey(nameof(GameSettings.GameMusic)))
                GameSettings.GameMusic = Utils.IntToBool(PlayerPrefs.GetInt(nameof(GameSettings.GameMusic)));
            if(PlayerPrefs.HasKey(nameof( GameSettings.ShootSound)))
                GameSettings.ShootSound = Utils.IntToBool(PlayerPrefs.GetInt(nameof(GameSettings.ShootSound)));
            if(PlayerPrefs.HasKey(nameof( GameSettings.Sensitivity)))
                GameSettings.Sensitivity = PlayerPrefs.GetFloat(nameof(GameSettings.Sensitivity));
        }
    }
}
