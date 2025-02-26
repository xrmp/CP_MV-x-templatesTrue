using UnityEngine;

public class PlayerMovementModel
{
    public float Speed { get; private set; }
    public Vector2 Direction { get; set; }

    public PlayerMovementModel(float speed)
    {
        Speed = speed;
    }
}