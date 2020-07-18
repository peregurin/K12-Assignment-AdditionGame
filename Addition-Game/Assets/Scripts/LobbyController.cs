using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{
    public Button playButton;
    public Button level1Button;
    public Button level2Button;
    public GameObject LevelsPopup;

    private void Awake()
    {
        playButton.onClick.AddListener(LoadPopup);
        level1Button.onClick.AddListener(LoadLevel1);
        level2Button.onClick.AddListener(LoadLevel2);
    }

    private void LoadPopup()
    {
        LevelsPopup.SetActive(true);
        playButton.transform.localScale = new Vector2(0,0);
    }

    private void LoadLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void LoadLevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
