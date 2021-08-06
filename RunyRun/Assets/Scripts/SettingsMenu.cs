using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioSource AudioSource;

    public Slider VolumeSlider;

    private float MusicVolume =1f;
    
    
   void Start() 
    {
        AudioSource.Play();
        // MusicVolume = PlayerPrefs.GetFloat("volume");
        // AudioSource.volume = MusicVolume;
        // VolumeSlider.value = MusicVolume;
    }

    void Update()
    {
        AudioSource.volume = MusicVolume;
        // PlayerPrefs.SetFloat("volume", MusicVolume);
    }

    public void UpdateVolume( float volume) 
    {
        MusicVolume = volume;
    }   
}
