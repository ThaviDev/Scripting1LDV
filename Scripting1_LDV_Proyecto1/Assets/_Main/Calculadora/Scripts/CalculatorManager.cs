using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculatorManager : MonoBehaviour
{
    [SerializeField]
    CButtonsManager bManager;
    char currentChar;
    int charType = 0;
    int[] myCurrrentNumbers;
    int mcNumberID;
    char mySymbol;
    float myAnswer;

    int onlyAcceptableInput = 0;

    string myStringDisplay;
    [SerializeField]
    TextMeshProUGUI myDisplayText;

    private void Start()
    {
        myCurrrentNumbers = new int[2];
        myCurrrentNumbers[0] = 0;
        myCurrrentNumbers[1] = 0;
        mcNumberID = 0;
    }

    void Update()
    {
        if (bManager.hasClicked)
        {
            currentChar = bManager.MyChar();
            charType = bManager.CharType();
            bManager.ConfirmValueFromCalculator();
            AddCharToOperation();
            print(currentChar);
        }
    }

    void AddCharToOperation()
    {
        if (mcNumberID == 0)
        {
            myStringDisplay = "";
        }
        // si ya estan los 2 numeros solo acepta '='
        if (mcNumberID == 2)
        {
            onlyAcceptableInput = 2;
        }
        // Input de numero
        if (charType == 1 && onlyAcceptableInput == 0)
        {
            // int.Parse transforma un string de numeros a numeros enteros.
            myCurrrentNumbers[mcNumberID] = int.Parse(currentChar.ToString()) ;
            print(currentChar + " debe ser igual a " + myCurrrentNumbers[mcNumberID]);
            mcNumberID++;
            onlyAcceptableInput = 1;
            myStringDisplay = myStringDisplay + currentChar + " ";
        }
        // Input de '='
        if (currentChar == '=' && onlyAcceptableInput == 2)
        {
            SolveIt();
        }
        // Input de simbolo
        if (charType == 2 && onlyAcceptableInput == 1)
        {
            mySymbol = currentChar;
            onlyAcceptableInput = 0;
            myStringDisplay = myStringDisplay + currentChar + " ";
        }
        myDisplayText.text = myStringDisplay;
    }

    void SolveIt()
    {
        myAnswer = 0;
        //print("mi primer numero " + myCurrrentNumbers[0]);
        //print("mi segundo numero " myCurrrentNumbers[1]);
        if (myCurrrentNumbers[1] == 0 || myCurrrentNumbers[0] == 0 && mySymbol == '/')
        {
            myAnswer = 9999999999999999999999999f;
        } else switch (mySymbol)
        {
            case '+':
                print("es una suma");
                myAnswer = myCurrrentNumbers[0] + myCurrrentNumbers[1];
                break;
            case '-':
                print("es una resta");
                myAnswer = myCurrrentNumbers[0] - myCurrrentNumbers[1];
                break;
            case '*':
                print("es una multi");
                myAnswer = myCurrrentNumbers[0] * myCurrrentNumbers[1];
                break;
            case '/':
                print("es una divi");
                myAnswer = myCurrrentNumbers[0] / myCurrrentNumbers[1];
                break;
        }
        myStringDisplay = "" + myAnswer;
        onlyAcceptableInput = 0;
        mcNumberID = 0;
        myDisplayText.text = myStringDisplay;
    }
}
