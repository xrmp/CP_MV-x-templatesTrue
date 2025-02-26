using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform spawnPoint;

    private void Start()
    {
        // Инициализация здоровья
        var playerModel = new PlayerModel(100);
        var playerInstance = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
        var playerView = playerInstance.GetComponent<PlayerView>();
        var playerController = new PlayerController(playerModel, playerView);

        // Инициализация перемещения
        var movementModel = new PlayerMovementModel(5f);
        var movementView = playerInstance.GetComponent<PlayerMovementView>();
        var movementController = new PlayerMovementController(movementModel, movementView);

        // Инициализация коллизий
        var collisionHandler = playerInstance.GetComponent<PlayerCollisionHandler>();
        collisionHandler.Initialize(playerController);

        // Обновление перемещения в Update
        UpdateManager.Instance.AddUpdateable(movementController);
    }
}