using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SettingsMenu : MonoBehaviour
{
    public static bool PauseGame = false;
    public GameObject pauseUI;
    // Start is called before the first frame update

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseGame)
            {
                Debug.Log("Resuming!");
                Resume();
            }
            else
            {
                Debug.Log("Paused!");
                Pause();
            }
        }
    }
    public void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }
    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
