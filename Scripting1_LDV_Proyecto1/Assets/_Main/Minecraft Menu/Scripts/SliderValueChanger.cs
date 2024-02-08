using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueChanger : MonoBehaviour
{
    private TMP_Text myText1;
    private TMP_Text myText2;
    private Slider mySlider;
    [SerializeField]
    private string firstString;
    [SerializeField]
    private string secondString;

    private void Start()
    {
        mySlider = GetComponent<Slider>();
        myText1 = this.gameObject.transform.Find("Text (TMP)").GetComponent<TMP_Text>();
        myText2 = this.gameObject.transform.Find("Bckgrnd Text").GetComponent<TMP_Text>();
        mySliderValueChanged();
    }
    public void mySliderValueChanged()
    {
        var newString = firstString + mySlider.value.ToString() + secondString;
        myText1.text = newString;
        myText2.text = newString;
    }
}
