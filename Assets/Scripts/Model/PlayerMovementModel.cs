using UnityEngine;

public class PlayerMovementModel
{
    private View _view;
    private Vector3 _playerPosition;

    public PlayerMovementModel(View view, Vector3 playerPosition)
    {
        _view = view;
        _playerPosition = playerPosition;
    }

    public void SetPosition(Vector3 playerPosition)
    {
        _playerPosition = playerPosition;
        _view.SetPosition(playerPosition);
    }
}
