using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word 
{
    DisplayWords display;
    public ChangeEmotion addValue;
    public string word;
    private int index;

    public Word(string word_, DisplayWords display_)
    {
        word = word_;
        display = display_;
        display.setWords(word);
        index = 0;
    }

    public char NextLetter()
    {
        return word[index];
    }

    public void LetterTyping()
    {
        index++;
        // Remove huruf di display
        display.DeleteLetter();
    }

    public void falseTyping()
    {
        display.ChangeColorFalse();
    }

    public bool TypedWord()
    {
        bool typed = (index >= word.Length);
        if (typed)
        {
            // Remove kata di display
            display.DeleteWord();
            //addValue.addValueSlider();
            GameInstance.addValueSlider?.Invoke(3);

        }
        return typed;
    }
}
