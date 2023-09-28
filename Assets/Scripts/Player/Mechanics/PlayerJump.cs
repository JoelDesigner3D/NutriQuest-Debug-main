using NaughtyAttributes;
using TNRD;
using UnityEngine;

/// <summary>
/// Makes the player jump with the physics engine.
/// </summary>
public class PlayerJump : MonoBehaviour, IJump
{
    [Header("Components")]
    [SerializeField] private Rigidbody _rb;
    [SerializeField, Label("Ground Detector")] private SerializableInterface<IGrounded> _groundedSerialized;

    [Header("Parameters")]
    [SerializeField] private float _jumpForce = 5f;

    // Properties for the interfaces
    private IGrounded _grounded => _groundedSerialized.Value;
   

    /// <summary>
    /// Makes the player jump with the physics engine based on the jump force.
    /// </summary>
    public void Jump()
    {
        if (_grounded.Grounded)
        {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }

    // test avec des paramètres
    public void Jump(Rigidbody rigidbody, float force, bool grounded)
    {
        _rb = rigidbody;
        _jumpForce = force;
        _grounded.Grounded = grounded;

        Jump();
    }

    // test avec des accesseurs
    public void SetRigidbody(Rigidbody rigidbody)
    {
        _rb = rigidbody;
    }

    public void SetJumpForce(float force)
    {
        _jumpForce = force;
    }

    public void SetGrounded(bool value)
    {
        _grounded.Grounded = value;
    }

    
}
