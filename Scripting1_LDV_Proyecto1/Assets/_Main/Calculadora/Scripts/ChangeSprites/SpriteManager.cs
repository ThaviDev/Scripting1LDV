using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer _spriteRenderer;
    [SerializeField]
    Sprite myNewSpriteImage;
    public void ChangeSprite()
    {
        _spriteRenderer.sprite = myNewSpriteImage;
    }
}
