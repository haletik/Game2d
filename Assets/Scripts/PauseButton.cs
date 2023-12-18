using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private GameObject _pauseWindow;

    private void Start()
    {
        _button.onClick.AddListener(Pause);
        Time.timeScale = 1;
    }

    private void Pause()
    {
        Time.timeScale = 0;
        _pauseWindow.SetActive(true);
    }
}