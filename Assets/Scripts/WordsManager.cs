using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordsManager : MonoBehaviour
{
    public List<Word> words;
    public Spawner spawner;
    public ChangeEmotion slider;

    private bool isWordActive;
    private Word WordActive;

    //private bool checkDetect = false;

    private void Start()
    {
        GameInstance.deleteWords += deleteWords;
    }

    private void deleteWords(Word obj)
    {
        isWordActive = false;
        words.Remove(obj);
        
    }

    public void AddWords()
    {
        var obj = spawner.SpawnWords();
        DisplayWords wdp = obj.GetComponent<DisplayWords>();
        Word word = new Word(WordsGenerator.RandomWord(), wdp);
        obj.GetComponent<CollisionDetection>().word = word;
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
}
