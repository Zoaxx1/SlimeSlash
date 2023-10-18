using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPowerUp : MonoBehaviour
{
    [SerializeField] private Sprite spriteBossOne;
    [SerializeField] private Sprite spriteBossTwo;
    [SerializeField] private Sprite spriteBossThree;
    [SerializeField] private Color colorOne;
    [SerializeField] private Color colorTwo;
    private SpriteRenderer spriteRenderer;
    private int counterOfPowerUps = 0;

    void Start()
    {
        SpawnSlimes spawnSlimes = gameObject.GetComponent<SpawnSlimes>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerLife>().TakeDamage();
        }
    }
    public void PowerUp()
    {
        counterOfPowerUps++;
        switch (counterOfPowerUps)
        {
            case 1:
                spriteRenderer.color = colorOne;
                break;
            case 2:
                spriteRenderer.sprite = spriteBossOne;
            break;
            case 3:
                spriteRenderer.color = colorTwo;
            break;
            case 4:
                spriteRenderer.sprite = spriteBossTwo;
            break;
            default:
                spriteRenderer.sprite = spriteBossThree;
                GameOver.Instance.endGame(false);
            break;
        }
        Vector2 scale = transform.localScale;
        scale.x += 10;
        transform.localScale = scale;
    }
}
