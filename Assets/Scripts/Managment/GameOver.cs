using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static GameOver Instance { get; private set; }
    [SerializeField] private GameObject posterCanvas;
    [SerializeField] private TextMeshProUGUI posterText;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(Instance);
    }

    public void endGame (bool heWon)
    {
        Time.timeScale = 0;
        posterCanvas.SetActive(true);
        if (heWon)
        {
            posterText.text = "You Win";
            posterText.color = Color.green;
        } else
        {
            posterText.text = "You Lose";
            posterText.color = Color.red;
        } 
    }
}
