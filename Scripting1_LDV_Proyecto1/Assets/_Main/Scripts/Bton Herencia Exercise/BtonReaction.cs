using UnityEngine;
using UnityEngine.UI;

public class BtonReaction : MonoBehaviour
{
    [SerializeField]
    Color myColor;
    // Virtual es que se puede pasar a otros codigos heredados
    public virtual void ChangeColor()
    {
        GetComponent<Image>().color = myColor;
    }
}
