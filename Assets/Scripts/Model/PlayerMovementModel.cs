using UnityEngine;

public class PlayerMovementModel
{
    private PlayerMovementView _view;
    private Vector3 _playerPosition;

    public void SetPosition(Vector3 playerPosition)
    {
        _playerPosition = playerPosition;
        _view.SetPosition(playerPosition);
    }

    public PlayerMovementModel(PlayerMovementView view, Vector3 playerPosition)
    {
        _view = view;
        _playerPosition = playerPosition;
    }
}
