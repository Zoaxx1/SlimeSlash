using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerRotate : MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        
        private bool _rotateToRight;

        private IPlayerMediator _player;

        public void Configure(IPlayerMediator player)
        {
            _player = player;
        }

        public bool RotateToRight
        {
            get { return _rotateToRight; }
            set { _rotateToRight = value; }
        }

        public void TryRotate()
        {
            _transform.eulerAngles = new Vector3(0, _transform.eulerAngles.y + 180, 0);
        }
    }
}