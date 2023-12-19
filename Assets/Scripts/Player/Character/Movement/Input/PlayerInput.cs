using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerInput : IPlayerMoveChanger
    {
        private float _speed;
        private Rigidbody2D _rb;

        public PlayerInput(float speed, Rigidbody2D rb)
        {
            _speed = speed;
            _rb = rb;
        }

        private void MovePlayer()
        {
            float XMove = Input.GetAxis("Horizontal");
            _rb.velocity = new Vector2(XMove * _speed, _rb.velocity.y);
        }

        public void MoveChange()
        {
            MovePlayer();
        }
    }
}