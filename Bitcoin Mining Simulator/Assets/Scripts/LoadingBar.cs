﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class LoadingBar : MonoBehaviour
{

    public GameObject bar;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time);
    }
}
