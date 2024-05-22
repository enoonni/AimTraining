using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gameplay.GameplayManager
{
    public class GameplayManager : MonoBehaviour
    {
        private string _currentNameScene;
        private TargetGenerator _targetGenerator;
        [SerializeField] private GameObject _target;

        private void Awake()
        {
            _currentNameScene = SceneManager.GetActiveScene().name;
            _targetGenerator = new TargetGenerator(_target, 3f, 7f, 4f);
        }
        int i = 0;
        private void FixedUpdate()
        {
            if(i++ < 10)
                _targetGenerator.SpawnTarget();
        }
    }
}
