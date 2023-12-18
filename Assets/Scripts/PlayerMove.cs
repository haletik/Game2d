using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpForce = 10f;
    [SerializeField] private float _checkRadius = 0.5f;
    [SerializeField] private Transform _feetPos;
    [SerializeField] private LayerMask _whatIsGround;
    private Rigidbody2D _rb;
    private float _moveInput;
    private bool _isGrounded;
    private PhysicsGroundChecker _physicsGroundChecker;

    public bool InJump => !_isGrounded;
    public float SpeedX => _rb.velocity.x;

    void Start()
    {
        _physicsGroundChecker = new PhysicsGroundChecker(_checkRadius, _whatIsGround);
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _isGrounded = _physicsGroundChecker.IsOnGround(_feetPos.position);
        _moveInput = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(_moveInput * _moveSpeed, _rb.velocity.y);

        if(_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector2.up * _jumpForce;
        }
    }
}