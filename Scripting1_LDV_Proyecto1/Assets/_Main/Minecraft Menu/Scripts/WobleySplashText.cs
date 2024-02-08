using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WobleySplashText : MonoBehaviour
{
    private float presentSize = 0.8f;
    [SerializeField]
    private float sizeMax = 1.5f;
    [SerializeField]
    private float sizeMin = 0.7f;
    private bool increasingOrDecreasing = true;
    [SerializeField]
    private float movementAmount;
    private void Start()
    {

    }
    private void Update()
    {
        if (increasingOrDecreasing) {
            presentSize += Time.deltaTime * movementAmount;
        } else if (!increasingOrDecreasing) { 
            presentSize -= Time.deltaTime * movementAmount; 
        }
        if (increasingOrDecreasing && presentSize > sizeMax)
        {
            increasingOrDecreasing = false;
        }
        if (!increasingOrDecreasing && presentSize < sizeMin)
        {
            increasingOrDecreasing = true;
        }

        transform.localScale = new Vector3 (presentSize, presentSize);
    }
}
