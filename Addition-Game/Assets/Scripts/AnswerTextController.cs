using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerTextController : MonoBehaviour
{
    private TMP_InputField answerText;
    public Button submitButton;
    public Add add;

    private void Awake()
    {
        answerText = GetComponent<TMP_InputField>();
        submitButton.onClick.AddListener(takeInput);
    }

    private void takeInput()
    {
        add.setAns(answerText.text);
    }

    public void ClearInputField()
    {
        answerText.text = "";
    }
}
