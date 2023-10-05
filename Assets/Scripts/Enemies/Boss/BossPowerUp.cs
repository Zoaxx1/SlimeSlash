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
        Vector2 scale = transform.localScale;
        counterOfPowerUps++;
        switch (counterOfPowerUps)
        {
            case 1:
                spriteRenderer.color = colorOne;
                scale.x += 10;
                break;
            case 2:
                spriteRenderer.sprite = spriteBossOne;
                scale.x += 10;
            break;
            case 3:
                spriteRenderer.color = colorTwo;
                scale.x += 10;
            break;
            case 4:
                spriteRenderer.sprite = spriteBossTwo;
                scale.x += 10;
                break;
            default:
                spriteRenderer.sprite = spriteBossThree;
                scale.x += 10;
                Time.timeScale = 0;
            break;
        }
        transform.localScale = scale;
    }
}
