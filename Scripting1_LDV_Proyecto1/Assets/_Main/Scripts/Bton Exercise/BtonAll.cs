using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BtonAll : MonoBehaviour
{
    // Crea una lista de objetos para Bton Reaction
    List<BtonReaction> _list = new List<BtonReaction>();
    void Start()
    {
        // Busca todos los objetos en la escena como un arreglo y lo transforma en una lista
        _list = FindObjectsOfType<BtonReaction>().ToList<BtonReaction>();

        GetComponent<Button>().onClick.AddListener(OnClickButton);
    }

    void OnClickButton()
    {
        // _list.Count; La cantidad de elementos de la lista
        for (int i = 0; i < _list.Count; i++)
        {
            _list[i].ChangeColor();
        }
    }

}
