using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float currentTime = 0.0f;
    private TextMeshProUGUI timer;

    private void Awake()
    {
        //currentTime = (int)Time.time;
        timer = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        Time.timeScale = 1;
        currentTime += Time.deltaTime;
        if (currentTime >= 30.0f)
        {
            Time.timeScale = 0.5f;
            if (currentTime >= 31.0f)
            {
                SceneManager.LoadScene(0);
            }
        }
        timer.text = "Time Left: " + (30 - (int)currentTime);
    }
}
