using UnityEngine;
using UnityEngine.SceneManagement;
using Gameplay.GameMode;

namespace Gameplay.GameplayManager
{
    public class GameplayManager : MonoBehaviour
    {
        private string _currentNameScene;
        private TargetGenerator _targetGenerator;
        private IGameModeSelector _gameMode;
        [SerializeField] private GameObject _target;

        private void Awake()
        {
            _currentNameScene = SceneManager.GetActiveScene().name;
            _targetGenerator = new TargetGenerator(_target, 3f, 7f, 4f);

            GameModeSelection();
        }
        
        private void FixedUpdate()
        {
            _gameMode.PlayGameMode();
        }

        private void GameModeSelection()
        {
            switch(_currentNameScene)
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
