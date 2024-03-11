using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    private bool isOnPause;

    private void Start()
    {
        isOnPause = false;
        Time.timeScale = 1.0f;
    }

    public void LoadLevel(int id)
    {
        if (id > (SceneManager.sceneCountInBuildSettings - 1))
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(id);
    }

    public void OnPauseBtnClick()
    {
        if (!isOnPause)
        {
            Time.timeScale = 0f;
            isOnPause = true;
            pauseScreen.SetActive(true);
        }
            
        else
        {
            Time.timeScale = 1f;
            isOnPause = false;
            pauseScreen.SetActive(false);
        }
    }

    public void OnMenuBtnClick()
    {
        LoadLevel(0);
    }

    public void OnRestartBtnClick()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnNextLvlBtnClick()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnExitBtnClick()
    {
        Application.Quit();
    }
}
