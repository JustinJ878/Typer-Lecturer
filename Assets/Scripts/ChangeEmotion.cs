using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeEmotion : MonoBehaviour
{
    public Sprite emt1, emt2, emt3, emt4;
    public Slider GOslider;
    public GameObject handle;

    private void Start()
    {
        GameInstance.addValueSlider += onAddValueSlider;
        GameInstance.decreaseValueSlider += onDecreaseValueSlider;
    }

    private void onAddValueSlider(int obj)
    {
        //throw new NotImplementedException();
        addValueSlider(obj);
    }

    private void onDecreaseValueSlider(int obj)
    {
        decreaseValueSlider(obj);
    }

    public void addValueSlider(int value = 3)
    {
        Debug.Log("value slider added");
        GOslider.value += 3;
        //GOslider.GetComponent<Slider>().value += 3;
    }

    public void decreaseValueSlider(int value = -3)
    {
        Debug.Log("value slider decreased");
        GOslider.value -= 3;
    }

    public void getValueSlider(float value)
    {
        Debug.Log(value);
       if(value == 100)
        {
            handle.GetComponent<Image>().sprite = emt1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (value > 50 & value < 100)
        {
            handle.GetComponent<Image>().sprite = emt2;
        }

        else if (value <= 50 & value != 0) 
        {
            handle.GetComponent<Image>().sprite = emt3;
        }
        else if (value == 0)
        {
            handle.GetComponent<Image>().sprite = emt4;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }


}
