using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class MyPauseBtn : MonoBehaviour
{
    [SerializeField] 
    MyAudioManager _audioMan;
    [SerializeField]
    Button _button;
    [SerializeField]
    int _myButtonID;
    [SerializeField]
    AudioClip _audioClip;
    private void Awake()
    {
        _button = GetComponent<Button>();
        _audioMan = FindObjectOfType<MyAudioManager>();
        if (_myButtonID == 1)
        {
            _button.onClick.AddListener(ClickPause);
        } else if (_myButtonID == 2)
        {
            _button.onClick.AddListener(ClickMute);
        } else if (_myButtonID == 3)
        {
            _button.onClick.AddListener(ClickPlay);
        }

    }
    public void ClickPause()
    {
        _audioMan.Pause();
    }

    public void ClickMute()
    {
        _audioMan.Mute();
    }
    public void ClickPlay()
    {
        _audioMan.PlayClip(_audioClip);
    }
}
