using UnityEngine;

public class PlayerMovementView : MonoBehaviour
{
    public void Move(Vector2 direction, float speed)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}