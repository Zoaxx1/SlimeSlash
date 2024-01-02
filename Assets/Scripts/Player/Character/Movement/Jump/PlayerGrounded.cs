using Assets.Scripts.Player;
using UnityEngine;

public class PlayerGrounded : MonoBehaviour
{
    private bool _isOnTheFloor;

    private IPlayerMediator _player;

    public void Configure(IPlayerMediator player)
    {
        _player = player;
    }

    public bool IsOnTheFloor
    {
        get { return _isOnTheFloor; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _isOnTheFloor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _isOnTheFloor = false;
        }
    }
}
