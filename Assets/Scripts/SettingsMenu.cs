using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        QualitySettings.SetQualityLevel(0);
    }

}
