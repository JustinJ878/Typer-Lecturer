using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputWord : MonoBehaviour
{
    public WordsManager wordsManager;

    void Update()
    {
        //Buat inputan dari keyboard
        foreach (char letter in Input.inputString)
        {
            wordsManager.LetterType(letter);
        }
    }
}
