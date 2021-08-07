using TMPro;
using UnityEngine;

namespace Development
{
    public class FPSCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _fpsText;
        private int _avgFrameRate;
        private int _oldFrame;
        private float _current;

        public void Update ()
        {
            _current = Time.frameCount / Time.time;
            _avgFrameRate = (int)_current;
            if (_oldFrame != _avgFrameRate)
            {
                _fpsText.text = $"FPS: {_avgFrameRate}";
                _oldFrame = _avgFrameRate;
            }
        }
    }
}
