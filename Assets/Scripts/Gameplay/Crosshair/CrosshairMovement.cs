using UnityEngine;

namespace Gameplay.Crosshair
{
    public class CrosshairMovement
    {
        private GameObject _crosshair;

        private Camera _mainCamera;

        public CrosshairMovement(GameObject crosshair)
        {
            _crosshair = crosshair;
            _mainCamera =  Camera.main;
        }

        public void Move()
        {
            var mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            _crosshair.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
        }
    }
}
