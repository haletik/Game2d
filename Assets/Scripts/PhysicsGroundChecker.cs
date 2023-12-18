using UnityEngine;

public class PhysicsGroundChecker
{
    private readonly float _checkRadius;
    private readonly LayerMask _whatIsGround;

    public PhysicsGroundChecker(float checkRadius, LayerMask whatIsGround)
    {
        _checkRadius = checkRadius;
        _whatIsGround = whatIsGround;
    }

    public bool IsOnGround(Vector2 feetPosition)
    {
        return Physics2D.OverlapCircle(feetPosition, _checkRadius, _whatIsGround);
    }
}