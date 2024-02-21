using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CButtonsManager : MonoBehaviour
{
    char myChar;
    int charType;
    public bool hasClicked;
    public void Click(string value) {
        myChar = value[0];
        // Checar si es una letra
        if (char.IsLetter(myChar))
        {
            print("Es una letra");
            charType = 0;
        }
        // Checar si es un numero
        else if (char.IsDigit(myChar))
        {
            print("Es un numero");
            charType = 1;
        }
        // Checar si es un simbolo
        else if (char.IsSymbol(myChar) || myChar == '-' || myChar == '*' || myChar == '/')
        {
            print("Es un simbolo");
            charType = 2;
        }
        hasClicked = true;
    }
    public char MyChar()
    {
        return myChar;
    }
    public int CharType()
    {
        return charType;
    }
    public void ConfirmValueFromCalculator()
    {
        hasClicked = false;
    }
}
