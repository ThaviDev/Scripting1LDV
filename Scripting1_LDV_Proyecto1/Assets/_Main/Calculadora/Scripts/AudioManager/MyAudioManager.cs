using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MyAudioManager : MonoBehaviour
{
    [Header("AUDIO SETTINGS")]
    [SerializeField]
    AudioSource _audioSource;

    static MyAudioManager Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Pause()
    {
        if (_audioSource.isPlaying)
        {
            _audioSource.Pause();
        } else
        {
            _audioSource.UnPause();
        }
    }
    public void Mute()
    {
        _audioSource.mute = !_audioSource.mute;
    }

    public void PlayClip(AudioClip clip)
    {
        _audioSource.PlayOneShot(clip);
    }
}
