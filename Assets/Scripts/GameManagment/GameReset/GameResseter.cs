using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameResseter : MonoBehaviour
{
    public void ResetTheGame()
    {
        SceneManager.LoadScene("Game");
    }
}
