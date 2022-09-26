using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private WordsManager WM;
    private bool check = false;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            check = true;
            Destroy(this.gameObject);
            GameInstance.decreaseValueSlider?.Invoke(-3);
        }
    }

    public bool returnBool()
    {
        return check;
    }

    public void SetCheck(bool check_)
    {
        check = check_;
    }
}
