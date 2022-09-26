using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWords : MonoBehaviour
{
    public Text text;
    public float speed = 13f;

    public void setWords (string word)
    {
        text.text = word;
    }

    public void DeleteLetter ()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.green;
    }

    public void ChangeColorFalse()
    {
        text.color = Color.red;
    }

    public void DeleteWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime * 5, 0f, 0f);
    }
}
