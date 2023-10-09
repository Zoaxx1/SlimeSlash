using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private Image lifeBar;
    [SerializeField] private float totalLife;
    private float actualLife;

    void Start()
    {
        actualLife = totalLife;
    }

    void Update()
    {
        if (actualLife == 0)
        {
            GameOver.Instance.endGame(false);
        }
    }
    public void TakeDamage()
    {
        actualLife -= 1;
        lifeBar.fillAmount = actualLife / totalLife;
    }
}
