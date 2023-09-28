using System;

public interface IGrounded
{
    bool Grounded { get; set; }

    event Action OnGrounded;
}
