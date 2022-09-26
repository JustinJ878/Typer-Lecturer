using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordsManager : MonoBehaviour
{
    public List<Word> words;
    public Spawner spawner;
    public ChangeEmotion slider;
    public CollisionDetection detect;

    private bool isWordActive;
    private Word WordActive;

    //private bool checkDetect = false;

    private void Start()
    {
        //checkDetect = detect.returnBool();
        //if (checkDetect)
        //{
        //    words.Remove(WordActive);
        //    isWordActive = false;
        //    checkDetect = false;
        //    detect.SetCheck(false);
        //}
    }

    public void AddWords()
    {
        Word word = new Word(WordsGenerator.RandomWord(), spawner.SpawnWords());
        Debug.Log(word.word);
        word.addValue = slider;
        
        words.Add(word);
    }

    public void LetterType(char letter)
    {
        if (isWordActive)
        {
            //Ngecek next wordnya apa
            if (WordActive.NextLetter() == letter)
            {
                WordActive.LetterTyping();
            }
            else
            {
                WordActive.falseTyping();
            }
                // Remove huruf dari kata
        }
        else
        {
            foreach(Word word in words)
            {
                if (word.NextLetter() == letter)
                {
                    WordActive = word;
                    isWordActive = true;
                    word.LetterTyping();
                    break;
                }
                //Bisa buat penalty (kalau niat :DD)
            }
        }

        if (isWordActive && WordActive.TypedWord()) 
        {
            isWordActive = false;
            words.Remove(WordActive);
        }
    }

    public Word GetWordActive()
    {
        Debug.Log(WordActive);
        return WordActive;
    }

}
