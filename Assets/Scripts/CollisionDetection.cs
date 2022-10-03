using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public WordsManager WM;
    public Word word;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            GameInstance.decreaseValueSlider?.Invoke(-3);
            GameInstance.deleteWords?.Invoke(word);
        }
    }
}
