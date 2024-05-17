using UnityEngine;

namespace Gameplay.Crosshair
{
    public class CrosshairManager : MonoBehaviour
    {
        private CrosshairSettings _settings;
        private CrosshairMovement _movement;

        [SerializeField] private GameObject _horizontalLine;
        [SerializeField] private GameObject _verticalLine;

        private void Awake()
        {
            _settings = new CrosshairSettings(_horizontalLine, _verticalLine);
            _movement = new CrosshairMovement(this.gameObject);
        }

        private void Update()
        {
            _movement.Move();
        }
    }
}
