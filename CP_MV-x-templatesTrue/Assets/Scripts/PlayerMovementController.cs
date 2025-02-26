using UnityEngine;

public class PlayerMovementController : IUpdateable
{
    private PlayerMovementModel _model;
    private PlayerMovementView _view;

    public PlayerMovementController(PlayerMovementModel model, PlayerMovementView view)
    {
        _model = model;
        _view = view;
    }

    public void Update()
    {
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        _model.Direction = direction;
        _view.Move(_model.Direction, _model.Speed);
    }
}