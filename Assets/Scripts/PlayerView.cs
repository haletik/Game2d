using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private PlayerMove _playerMove;
    [SerializeField]
    private float _mirroringXOffset = 0.3f;
    
    public void Update()
    {
        _animator.SetBool("Jumping", _playerMove.InJump);    
        _animator.SetFloat("Speed", Mathf.Abs(_playerMove.SpeedX));

        var scale = transform.localScale;
        if(_playerMove.SpeedX > 0.1f && scale.x > 0.5f)
        {
            scale.x = -1;
            transform.position = new Vector3(transform.position.x + _mirroringXOffset, transform.position.y);
        }
        else if(_playerMove.SpeedX < -0.1f && scale.x < -0.5f)
        {
            scale.x = 1;
            transform.position = new Vector3(transform.position.x - _mirroringXOffset, transform.position.y);
        }

        transform.localScale = scale;
    }
}