using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public WordsManager wordManager;

    public float delay = 5f;
    private float nextTime = 0f;

    private void Update()
    {
        if (Time.time >= nextTime)
        {
            wordManager.AddWords();
            nextTime = Time.time + delay;
            if (delay > 0.8) 
            {
                delay -= 0.02f;
            }
        }
    }
}
