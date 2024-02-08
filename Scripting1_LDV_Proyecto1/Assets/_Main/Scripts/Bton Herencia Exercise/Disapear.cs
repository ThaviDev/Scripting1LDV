using UnityEngine;
using UnityEngine.UI;

public class Disapear : BtonReaction
{
    // Este código tiene como herencia Bton Reaction, por lo tanto tiene todo lo que Bton Reaction tiene.
    // Override es para poder sobreescribir un código de la herencia
    public override void ChangeColor()
    {
        // Hace la imagen transparente
        GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
    }
}
