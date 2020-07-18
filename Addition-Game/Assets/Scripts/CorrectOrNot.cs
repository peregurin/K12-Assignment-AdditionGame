using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CorrectOrNot : MonoBehaviour
{
    private TextMeshProUGUI feedback;
    public IceCreamSpawner IceCreamSpawner;

    private void Awake()
    {
        feedback = GetComponent<TextMeshProUGUI>();
    }

    public void refreshFeedbackC(int number)
    {
        feedback.text = "correct";
        IceCreamSpawner.InstantiateIceCreamScoops(number);
    }

    public void refreshFeedbackW()
    {
        feedback.text = "wrong";
    }

    public void clearScoopStack()
    {
        IceCreamSpawner.ClearScoopStack();
    }
}
