using UnityEngine;

public class Bag : MonoBehaviour
{
    [SerializeField]
    private Audio _audio;
    
    public int Score { get; private set; }

    private void Start()
    {
        if(PlayerPrefs.HasKey("Score"))
            Score = PlayerPrefs.GetInt("Score");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Star"))
        {
            Score++;
            PlayerPrefs.SetInt("Score", Score);
            _audio.PlayStarSound();
            Destroy(other.gameObject);
        }
    }
}