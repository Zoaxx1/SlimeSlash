using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private float _jumpForce;
        [SerializeField] private float _gravityScaleInJump;
        [SerializeField] private float _gravityScaleOutJump;
        [SerializeField] private Rigidbody2D _rb;

        private IPlayerMediator _player;

        public void Configure(IPlayerMediator player)
        {
            _player = player;
        }

        public bool InputUpActionPressed()
        {
            return Input.GetKeyDown("up");
        }
        public void TryJump()
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
            _rb.gravityScale = _gravityScaleInJump;
        }

        public bool YPlayerIsLessThanZero()
        {
            return _rb.velocity.y < 0;
        }
        public void TryFall()
        {
            _rb.gravityScale = _gravityScaleOutJump;
        }

    }
}