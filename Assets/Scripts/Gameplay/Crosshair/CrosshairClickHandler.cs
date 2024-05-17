using UnityEngine;

namespace Gameplay.Crosshair
{
    public class CrosshairClickHandler
    {
        private GameObject _crosshair;
        private RaycastHit2D _hit;

        public void Hit()
        {    
            _hit = Physics2D.Raycast(_crosshair.transform.position, Vector2.zero);

            if (_hit.collider.tag == ("Target"))
            {                    
                
            }
        }
    }
}
