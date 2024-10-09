using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Numpad : MonoBehaviour
{
    //Get Input Field
    public TMP_InputField inputField;

    //The function who handle all the button clicked in Numpad
    public void NumpadButtonHandler(string value)
    {
        if (value == "Submit")
        {
            Debug.Log(inputField.text);
            return;
        }
        else if (value == "Backspace")
        {
            if (inputField.text.Length > 0)
            {
                inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
            }
        }
        else
        {
            inputField.text += value;
            return;
        }
    }
}
