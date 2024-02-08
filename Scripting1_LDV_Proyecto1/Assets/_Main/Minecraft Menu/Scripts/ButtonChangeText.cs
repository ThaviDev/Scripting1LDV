using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonChangeText : MonoBehaviour
{
    private TMP_Text myText1;
    private TMP_Text myText2;
    [SerializeField]
    private string[] myStrings;
    private int myIndex = 0;
    void Start()
    {
        myText1 = this.gameObject.transform.Find("Text (TMP)").GetComponent<TMP_Text>();
        myText2 = this.gameObject.transform.Find("Bckgrnd Text").GetComponent<TMP_Text>();
        myButtonPressed();
    }

    public virtual void myButtonPressed()
    {
        var newString = myStrings[myIndex];
        myText1.text = newString;
        myText2.text = newString;
        if (myStrings.Length <= myIndex + 1)
        {
            myIndex = 0;
        }
        else
        {
            myIndex++;
        }
    }
}
