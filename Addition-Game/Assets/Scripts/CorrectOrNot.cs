using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CorrectOrNot : MonoBehaviour
{
    private TextMeshProUGUI feedback;

    private void Awake()
    {
        feedback = GetComponent<TextMeshProUGUI>();
    }

    public void refreshFeedbackC()
    {
        feedback.text = "correct";
    }

    internal void refreshFeedbackW()
    {
        feedback.text = "wrong";
    }
}
