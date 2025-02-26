using System;

public class PlayerModel
{
    public event Action<int> OnHealthChange;
    public event Action OnPlayerDeath;

    private int _maxHealth;
    private int _currentHealth;

    public int MaxHealth => _maxHealth;

    public PlayerModel(int maxHealth)
    {
        _maxHealth = maxHealth;
        _currentHealth = maxHealth;
    }

    public void ChangeHealth(int amount)
    {
        _currentHealth = Math.Clamp(_currentHealth + amount, 0, _maxHealth);
        OnHealthChange?.Invoke(_currentHealth);

        if (_currentHealth == 0)
        {
            OnPlayerDeath?.Invoke();
        }
    }
}