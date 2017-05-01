using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Calculator : MonoBehaviour {


    public Text inputField;
    string screenValueHistory;
    int[] numbers = new int[2];
    string calculatorSymbols;
    int i = 0;
    int calculationResult;
    bool displayedResults = false;

	public void ButtonPressed ()
    {
        if (displayedResults == true)
        {
            
            screenValueHistory = "";
           
        }
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        screenValueHistory += buttonValue;

        int argument;
        if (int.TryParse(buttonValue, out argument))
        {
            if (i > 1) i = 0;
            numbers[i] = argument;
            i++;
        }
        else
        {
            switch (buttonValue)
            {
                case "+":
                    calculatorSymbols = buttonValue;
                    break;
                case "-":
                    calculatorSymbols = buttonValue;
                    break;
                case "=":
                    switch (calculatorSymbols)
                    {
                        case "+":
                            calculationResult = numbers[0] + numbers[1];
                            break;
                        case "-":
                            calculationResult = numbers[0] - numbers[1];
                            break;
                    }
                    displayedResults = true;
                    screenValueHistory = calculationResult.ToString();
                    numbers = new int[2];
                    break;

                   
                    }
            }
        

        

        inputField.text = screenValueHistory;
    }
}
  