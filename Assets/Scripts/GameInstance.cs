using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstance : MonoBehaviour
{
    public static Action<int> addValueSlider;
    public static Action<int> decreaseValueSlider;
    public static Action<Word> deleteWords;
}
