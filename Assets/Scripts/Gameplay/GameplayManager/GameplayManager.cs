using UnityEngine;
using UnityEngine.SceneManagement;
using Gameplay.GameMode;

namespace Gameplay.GameplayManager
{
    public class GameplayManager : MonoBehaviour
    {
        private TargetGenerator _targetGenerator;
        private IGameModeSelector _gameMode;
        [SerializeField] private GameObject _target;

        public Stopwatch GameStopwatch{ get; private set; }

        private void Awake()
        {
            _targetGenerator = new TargetGenerator(_target, 3f, 7f, 4f);

            GameStopwatch = new Stopwatch();

            GameModeSelection();
            
            GameStopwatch.Start();
        }
        
        private void FixedUpdate()
        {
            _gameMode.PlayGameMode();

            GameStopwatch.CountTime();
        }

        private void GameModeSelection()
        {
            switch(SceneManager.GetActiveScene().name)
            {
                case "Survival":
                {
                    _gameMode = new GameModeSurvival(_targetGenerator);
                    break;
                }

                default:
                {
                    break;
                }
            }
        }
    }
}
