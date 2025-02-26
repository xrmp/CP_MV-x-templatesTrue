using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Text healthText;
    [SerializeField] private SpriteRenderer playerSprite;

    public void UpdateHealthDisplay(int health)
    {
        if (healthText != null)
        {
            healthText.text = $"Health: {health}";
        }
    }

    public void ChangePlayerColor(Color color)
    {
        if (playerSprite != null)
        {
            playerSprite.color = color;
        }
    }
}