using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;

    [SerializeField] public Text BackTimer;

    public void Start()
    {
        currentTime = startingTime;
    }

    public void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        BackTimer.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
