using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player.Bullet
{
    public class BulletMover : MonoBehaviour
    {
        [SerializeField] private float speed;

        private Rigidbody2D rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            rb.MovePosition(transform.position + transform.right * speed * Time.fixedDeltaTime);
        }
    }
}