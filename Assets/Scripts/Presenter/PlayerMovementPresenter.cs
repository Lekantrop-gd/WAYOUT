using UnityEngine;

public class PlayerMovementPresenter
{
    private PlayerMovementModel _model;

    public PlayerMovementPresenter(PlayerMovementModel model) 
    {  
        _model = model; 
    }

    public void Move(Vector3 pointerPosition, Vector3 playerPosition, float verticalSpeed, float horizontalSpeed)
    {
        Vector3 startPosition = playerPosition;
        Vector3 endPosition = new Vector3(pointerPosition.x, playerPosition.y + verticalSpeed);

        Vector3 position = Vector3.MoveTowards(startPosition, endPosition, horizontalSpeed * Time.deltaTime);
        _model.SetPosition(position);
    }
}
