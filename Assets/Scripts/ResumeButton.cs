using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private GameObject _pauseWindow;

    private void Start()
    {
        _button.onClick.AddListener(Resume);
    }

    private void Resume()
    {
        Time.timeScale = 1;
        _pauseWindow.SetActive(false);
    }
}