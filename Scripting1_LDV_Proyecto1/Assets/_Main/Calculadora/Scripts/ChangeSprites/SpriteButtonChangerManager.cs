using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteButtonChangerManager : MonoBehaviour
{
    Button _myButton;
    [SerializeField]
    SpriteManager _srManager;
    void Start()
    {
        _myButton = GetComponent<Button>();
        _myButton.onClick.AddListener(changeSpriteImage);
    }
    void changeSpriteImage()
    {
        _srManager.ChangeSprite();
    }
}
