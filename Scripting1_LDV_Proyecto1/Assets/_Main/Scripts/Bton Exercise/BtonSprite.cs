using UnityEngine;
using UnityEngine.UI;


public class BtonSprite : BtonReaction
{
    // Este c�digo tiene como herencia Bton Reaction, por lo tanto tiene todo lo que Bton Reaction tiene.
    [SerializeField]
    private Sprite mySprite;
    // Override es para poder sobreescribir un c�digo de la herencia
    public override void ChangeColor()
    {
        GetComponent<Image>().sprite = mySprite;
    }
}
