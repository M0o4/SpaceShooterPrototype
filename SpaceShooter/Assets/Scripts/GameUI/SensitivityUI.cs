using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameUI
{
    public class SensitivityUI : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private TextMeshProUGUI _sensetivityText;

        private void Start()
        {
            _slider.value = GameSettings.GameSettings.Sensitivity;
            _sensetivityText.text = GameSettings.GameSettings.Sensitivity.ToString("F2");
            _slider.onValueChanged.AddListener(delegate(float arg0) { SensitivityChange(); });
        }

        private void SensitivityChange()
        {
            GameSettings.GameSettings.Sensitivity = _slider.value;
            _sensetivityText.text = GameSettings.GameSettings.Sensitivity.ToString("F2");
            GameSettings.GameSettings.SensitivityChanged();
        }
    }
}
