using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MyNewScript : MonoBehaviour
{
    public float currentLife;
    public float maxLife;
    public Slider lifeBar;

    void Start()
    {
        lifeBar = GetComponent<Slider>();
    }

    void Update()
    {
        lifeBar.value = currentLife;
    }
}
