using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonToAnotherScene : MonoBehaviour
{
    [SerializeField]
    private string _nextLevel;

    public void Start()
    {
        GetComponent<Button>().onClick.AddListener(LoadNextLevel);
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(_nextLevel);
    }
}