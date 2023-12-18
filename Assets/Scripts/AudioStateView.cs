using UnityEngine;
using UnityEngine.UI;

public class AudioStateView : MonoBehaviour
{
    [SerializeField]
    private Image _spriteRenderer;
    [SerializeField]
    private Audio _audio;

    private void Update()
    {
        _spriteRenderer.enabled = !_audio.Enabled;
    }
}