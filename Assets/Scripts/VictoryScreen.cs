using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VictoryScreen : MonoBehaviour
{
    public GameObject winScreenUI;
    // Start is called before the first frame update
    public void displayWinScreen()//bool hasWon)
    {
        //if(hasWon)
        //{
            winScreenUI.SetActive(true);
            Time.timeScale = 0f;
        //}
    }

    public void NewGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        winScreenUI.SetActive(false);
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

