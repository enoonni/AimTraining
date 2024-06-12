using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Gameplay;
using Gameplay.GameplayManager;
using Unity.VisualScripting;

namespace UI.Gameplay
{
    class StopwatchUI : MonoBehaviour
    {
        [SerializeField] private GameplayManager _gameplayManager;
        private Stopwatch _stopwatch;
        private TextMeshProUGUI _text;        

        private void Start()
        {
            _stopwatch = _gameplayManager.GameStopwatch;

            _text = GetComponent<TextMeshProUGUI>();           
            WriteStopwatch(null, 0f);
            _stopwatch.OnTimeChanged += WriteStopwatch;
        }

        private void WriteStopwatch(object sender, float time)
        {
            _text.text = string.Format("{0:00}:{1:00}", 
                                    Mathf.FloorToInt(time / 60), 
                                    Mathf.FloorToInt(time % 60), 
                                    (int)(time * 1000) % 1000);
        }
    }
}