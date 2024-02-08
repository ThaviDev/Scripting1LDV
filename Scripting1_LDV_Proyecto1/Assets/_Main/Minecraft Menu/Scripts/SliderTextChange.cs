using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderTextChange : MonoBehaviour
{
    private TMP_Text myText1;
    private TMP_Text myText2;
    [SerializeField]
    private string[] myStrings;
    private Slider mySlider;
    private void Start()
    {
        myText1 = this.gameObject.transform.Find("Text (TMP)").GetComponent<TMP_Text>();
        myText2 = this.gameObject.transform.Find("Bckgrnd Text").GetComponent<TMP_Text>();
        mySlider = GetComponent<Slider>();
        mySliderValueChanged();
    }
    public void mySliderValueChanged()
    {
        var newString = myStrings[(int)mySlider.value];
        myText1.text = newString;
        myText2.text = newString;
    }

}
