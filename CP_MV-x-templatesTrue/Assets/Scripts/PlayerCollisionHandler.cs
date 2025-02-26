using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    private PlayerController _playerController;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _playerController.TakeDamage(10);
        }
    }
}