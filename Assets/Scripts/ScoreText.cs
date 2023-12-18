using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;
    [SerializeField]
    private Bag _bag;
    
    private void Update()
    {
        _text.text = $"Score: {_bag.Score}";
    }
}