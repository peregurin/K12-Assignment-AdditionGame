using TMPro;
using UnityEngine;

public class QuestionTextController : MonoBehaviour
{
    private TextMeshProUGUI question;

    private void Awake()
    {
        question = GetComponent<TextMeshProUGUI>();
    }

    public void ShowQuestionOnScreen(int number1, int number2)
    {
        question.text = number1 + "  +  " + number2;
    }
}
