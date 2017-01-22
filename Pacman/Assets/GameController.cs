using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    
    public GUIText gameOverText;

    private bool gameOver;
    
    

    void Start()
    {
        gameOver = false;
        gameOverText.text = "";
        
        
        
    }
    
    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
