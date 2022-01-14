using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void volumeSlider(float vol)
    {
        // Log10 since volume is in decibels, also slider values must be from -80 to 0
        audioMixer.SetFloat("musicvolume", Mathf.Log10(vol) * 20);
    }

    public void setHigh(bool state)
    {
        if (state == true)
        {
            QualitySettings.SetQualityLevel(5, true);
            Debug.Log(QualitySettings.GetQualityLevel());
        }
    }

    public void setMedium(bool state1)
    {
        if (state1)
        {
            QualitySettings.SetQualityLevel(3, true);
            Debug.Log(QualitySettings.GetQualityLevel());
        }
    }

    public void setLow(bool state2)
    {
        if (state2)
        {
            QualitySettings.SetQualityLevel(0, true);
            Debug.Log(QualitySettings.GetQualityLevel());
        }
    }
    // Start is called before the first frame update
    /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } */
}
