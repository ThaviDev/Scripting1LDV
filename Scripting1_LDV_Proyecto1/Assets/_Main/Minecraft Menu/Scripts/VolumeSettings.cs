using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField]
    AudioMixer myAudioMixer;
    [SerializeField]
    Slider musicSlider;
    [SerializeField]
    Slider sfxSlider;
    [SerializeField]
    Slider masterSlider;

    const string MIXER_MUSIC = "myMusicVolume";
    const string MIXER_SFX = "mySFXVolume";
    const string MIXER_MASTER = "myMasterVolume";


    private void Awake()
    {
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);
        masterSlider.onValueChanged.AddListener(SetMasterVolume);
    }

    private void SetMusicVolume(float value)
    {
        myAudioMixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value/100) * 40);
    }
    private void SetSFXVolume(float value)
    {
        myAudioMixer.SetFloat(MIXER_SFX, Mathf.Log10(value / 100) * 40);
    }
    private void SetMasterVolume(float value)
    {
        myAudioMixer.SetFloat(MIXER_MASTER, Mathf.Log10(value / 100) * 40);
    }
}
