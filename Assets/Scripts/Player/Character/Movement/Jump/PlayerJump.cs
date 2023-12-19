using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerJump : IPlayerMoveChanger
    {
        private float _jumpForce;
        private float _gravityScaleInJump;
        private float _gravityScaleOutJump;
        private Rigidbody2D _rb;

        public PlayerJump(
            float jumpForce, 
            float gravityScaleInJump,
            float gravityScaleOutJump,
            Rigidbody2D rb
            )
        {
            _jumpForce = jumpForce;
            _gravityScaleInJump = gravityScaleInJump;
            _gravityScaleOutJump = gravityScaleOutJump;
            _rb = rb;
        }

        private void Jump()
        {
            if (Input.GetKeyDown("up") && PlayerGrounded._isGrounded)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
                _rb.gravityScale = _gravityScaleInJump;
            }
            if (_rb.velocity.y < 0)
            {
                _rb.gravityScale = _gravityScaleOutJump;
            }
        }

        public void MoveChange()
        {
            Jump();
        }
    }
}