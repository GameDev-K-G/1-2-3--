using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject WinUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void win()
    {
        WinUI.SetActive(true);
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
