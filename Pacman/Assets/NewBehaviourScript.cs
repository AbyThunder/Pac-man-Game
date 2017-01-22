using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip saw;
    private int count;
    public Text countText;
    public Text winText;
    public Text loseText;

    void Start()
    {
        count = 0;
        setCountText();
        winText.text = "";
        loseText.text = "";
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
        

    }

    public void LoadByIndex(int number)
    {
        number = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(number);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TicTacs")
        {
            Destroy(collision.gameObject);
            count = count + 1;
            setCountText();
            GetComponent<AudioSource>().Play();

        }
        if(collision.gameObject.tag == "Ghost")
        {
            Time.timeScale = 0;
            loseText.text = "YOU LOSE";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    void setCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 162)
        {
            winText.text = "GG";
            
        }
    }

    
}



