using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]
    private AudioClip _starSound;
    [SerializeField]
    private AudioSource _audioSource;

    public bool Enabled { get; private set; } = true;

    public void ToggleState()
    {
        if(Enabled)
            Disable();
        else
            Enable();
    }

    public void PlayStarSound()
    {
        if(!Enabled)
            return;
        
        _audioSource.PlayOneShot(_starSound);
    }

    private void Enable()
    {
        Enabled = true;
        _audioSource.Play();
    }

    private void Disable()
    {
        Enabled = false;
        _audioSource.Pause();
    }
}