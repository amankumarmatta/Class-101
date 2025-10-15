using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

  [SerializeField] private Button playButton, quitButton;

  void Start()
  {
    playButton.onClick.AddListener(Play);
    quitButton.onClick.AddListener(Quit);
  }

  public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Quit()
    {
        Debug.LogWarning("Application Closed");
        Application.Quit();
    }
}
