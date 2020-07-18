using UnityEngine;


public class Add : MonoBehaviour
{
    private int userAns;
    private int number1;
    private int number2;
    public int maxAns = 9;

    public QuestionTextController questionText;
    public CorrectOrNot feedback;

    private void Start()
    {
        GetQuestion();
    }

    private void GetQuestion()
    {
        number1 = (int)Random.Range(0f, 9f);
        number2 = (int)Random.Range(0f, 9f);
        if(number2 > maxAns - number1)
        {
            number2 = maxAns - number1;
        }
        questionText.ShowQuestionOnScreen(number1, number2);
        Debug.Log(number1 + "+" + number2);
    }

    public void setAns(string text)
    {
        userAns = int.Parse(text);
        feedback.clearScoopStack();
        if (number1 + number2 == userAns)
        {
            
            feedback.refreshFeedbackC(userAns);
            GetQuestion();
        }
        else
        {
            feedback.refreshFeedbackW();
            GetQuestion();
        }
    }
}
