using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonBehaviour : MonoBehaviour
{
    public AudioSource m_MyAudioSource;
    public Slider VolumeSlider;
    private void Start()
    {
        m_MyAudioSource.enabled = true;
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1);
        }
        else
        {
            OnLoad();
        }
    }
    public void OnAudioClick()
    {
        m_MyAudioSource.enabled = !m_MyAudioSource.enabled;
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
