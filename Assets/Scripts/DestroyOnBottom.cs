using UnityEngine;

public class DestroyOnBottom : MonoBehaviour
{
    [SerializeField]
    private float _bottomBoundY = -7;

    private void Update()
    {
        if(transform.position.y < _bottomBoundY)
            Destroy(gameObject);
    }
}