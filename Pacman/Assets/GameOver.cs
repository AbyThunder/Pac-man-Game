using UnityEngine;

public class gameController : MonoBehaviour
{
    private bool gameOver;
    public GUIText gameOverText;
    void Start()
    {
        gameOver = false;
        gameOverText.text = "";



    }

    void OnTriggerEnter(Collider other)
    {
        
        
        if (other.tag == "Player")
        {

            gameOverText.text = "Game Over!";
            gameOver = true;
        }
        
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
