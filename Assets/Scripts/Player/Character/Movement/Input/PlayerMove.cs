using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody2D _rb;

        private float _xMove = 0;

        private IPlayerMediator _player;

        public void Configure(IPlayerMediator player)
        {
            _player = player;
        }

        public float XMove
        {
            get { return _xMove; }
        }

        public float InputHorizontalActionPressed()
        {
            _xMove = Input.GetAxis("Horizontal");
            return _xMove;
        }

        public void TryMove()
        {
            _rb.velocity = new Vector2(_xMove * _speed, _rb.velocity.y);
        }
    }
}