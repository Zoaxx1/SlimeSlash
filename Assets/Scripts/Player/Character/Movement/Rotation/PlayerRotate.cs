using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerRotate : IPlayerMoveChanger
    {
        private Transform _transform;
        private bool _rotateToRight;

        public PlayerRotate(Transform transform)
        {
            _transform = transform;
            _rotateToRight = true;
        }

        private void RotatePlayer()
        {
            float XMove = Input.GetAxis("Horizontal");
            if (XMove < 0 && _rotateToRight)
            {
                Rotate();
            }
            else if (XMove > 0 && !_rotateToRight)
            {
                Rotate();
            }
        }

        private void Rotate()
        {
            _rotateToRight = !_rotateToRight;
            _transform.eulerAngles = new Vector3(0, _transform.eulerAngles.y + 180, 0);
        }

        public void MoveChange()
        {
            RotatePlayer();
        }
    }
}