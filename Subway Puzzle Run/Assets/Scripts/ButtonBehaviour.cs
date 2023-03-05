using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonBehaviour : MonoBehaviour
{
    public Slider VolumeSlider;
    private void Start()
    {
        if(!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1);
        }
        else
        {
            OnLoad();
        }
    }
    // Start is called before the first frame update
    public void OnQuit()
    {
        Application.Quit();
    }
    public void OnPlay()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void OnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void OnVolumeChange()
    {
        if (VolumeSlider == null)
        {
            return;
        }
        VolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        Save();
    }

    public void OnLoad()
    {
        if (VolumeSlider == null)
        {
            return;
        }
        VolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }


    public void Save()
    {
        if (VolumeSlider == null)
        {
            return;
        }
        PlayerPrefs.SetFloat("MusicVolume",VolumeSlider.value);
    }
}
