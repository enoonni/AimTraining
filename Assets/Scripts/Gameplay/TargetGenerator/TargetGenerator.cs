using UnityEngine;

namespace Gameplay.TargetGenerator
{
    public class TargetGenerator
    {        
        private GameObject _target;
        private float _lifeTimeSec;

        public TargetGenerator(GameObject target, float lifeTime)
        {
            _target = target;

            _lifeTimeSec = lifeTime;
        }

        public void SpawnTarget()
        {

        }

        private Vector3 GetRandomPos()
        {
            
            return new Vector3();
        }
    }
}
