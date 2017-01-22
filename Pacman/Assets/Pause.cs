using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    public GameObject Canvas;
    public GameObject Camera;
    bool Paused = false;
    public static bool visible = false;

    void Start()
    {
        Canvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused == true)
            {
                Time.timeScale = 1.0f;
                Canvas.gameObject.SetActive(false);
                Paused = false;
                Cursor.visible = false;
            }
            else {
                Time.timeScale = 0.0f;
                Canvas.gameObject.SetActive(true);
                Paused = true;
                Cursor.visible = true;
            }
        }
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        Canvas.gameObject.SetActive(false);
    }
}
