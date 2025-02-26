using UnityEngine;
public class PlayerController
{
    private PlayerModel _model;
    private PlayerView _view;

    public PlayerController(PlayerModel model, PlayerView view)
    {
        _model = model;
        _view = view;

        _model.OnHealthChange += OnHealthChanged;
        _model.OnPlayerDeath += OnPlayerDeath;
    }

    private void OnHealthChanged(int health)
    {
        _view.UpdateHealthDisplay(health);
        _view.ChangePlayerColor(Color.Lerp(Color.red, Color.green, health / (float)_model.MaxHealth));
    }

    private void OnPlayerDeath()
    {
        Debug.Log("Player has died!");
    }

    public void TakeDamage(int damage)
    {
        _model.ChangeHealth(-damage);
    }
}