using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MyVector3
{
    public float x;
    public float y;
    public float z;
}

public class MyTransform
{
    public MyVector3 position;
    public MyVector3 rotation;
    public MyVector3 scale;
}

public class LifeCounter : MonoBehaviour
{
    [SerializeField]
    private float currentLife;
    //[SerializeField] 
    //private float maxLife;
    private Slider lifeBar;
    public MySceneManager mySceneManager;
    [SerializeField]
    [Header("Default = 1")]
    float regenRate = 1f;
    [SerializeField]
    [Header("Default = 0.1")]
    float healthDecreaseRate = 0.1f;
    [SerializeField]
    [Header("Default = 0.1")]
    float healthIncreaseRate = 0.1f;
    [SerializeField]
    TMP_Text text;

    MyTransform trans;

    void Start()
    {
        lifeBar = GetComponent<Slider>();
        //trans.position.x = transform.position.x;
        //print(trans.position.x);
    }

    void Update()
    {
        lifeBar.value = currentLife;
        if (Input.GetKey(KeyCode.Space)) {
            currentLife -= healthDecreaseRate;
        }
        else if (Input.GetKey(KeyCode.E)) {
            currentLife += healthIncreaseRate;
        }
        else if (currentLife < 100) {
            currentLife += Time.deltaTime * regenRate;
        }
        if (currentLife > 100)
        {
            currentLife = 100;
        }
        if (currentLife <= 0)
        {
            mySceneManager.Btn(0);
        }
        var currentIntLife = (int)currentLife;
        text.text = currentIntLife.ToString();
    }
}
