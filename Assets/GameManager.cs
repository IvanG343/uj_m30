using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject looseScreen;

    private void Awake()
    {
        instance = this;
    }

    public void Win()
    {
        winScreen.SetActive(true);
    }

    public void Loose()
    {
        looseScreen.SetActive(true);
    }

}
