using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerTextController : MonoBehaviour
{
    private TMP_InputField answerText;

    private void Awake()
    {
        answerText = GetComponent<TMP_InputField>();
    }

    public void ClearInputField()
    {
        answerText.text = "";
    }
}
