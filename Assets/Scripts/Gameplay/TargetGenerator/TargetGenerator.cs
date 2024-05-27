using UnityEngine;

namespace Gameplay
{
    public class TargetGenerator
    {        
        private GameObject _target;
        private float _lifeTimeSec;

        private float _maxRangeX;
        private float _maxRangeY;

        public TargetGenerator(GameObject target, float lifeTime, float maxRangeX, float maxRangeY)
        {
            _target = target;
            _lifeTimeSec = lifeTime;
            
            _maxRangeX = maxRangeX;
            _maxRangeY = maxRangeY;
        }

        public void SpawnTarget()
        {
            var position = GetRandomPos();
            UnityEngine.Object.Instantiate(_target, position, Quaternion.identity);
        }

        private Vector3 GetRandomPos()
        {   
            var randomPositon = new Vector3(Random.Range(-_maxRangeX, _maxRangeX), Random.Range(-_maxRangeY, _maxRangeY), 0);         
            return randomPositon;
        }
    }
}
