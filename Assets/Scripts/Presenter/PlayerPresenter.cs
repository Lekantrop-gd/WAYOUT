using UnityEngine;

public class PlayerPresenter
{
    private PlayerModel _model;
    private float _verticalSpeed;
    private float _horizontalSpeed;

    public PlayerPresenter(PlayerModel model, float verticalSpeed, float horizontalSpeed) 
    {  
        _model = model; 
        _verticalSpeed = verticalSpeed;
        _horizontalSpeed = horizontalSpeed;
    }

    public void Move(Vector3 startPosition, Vector3 endPosition)
    {
        Vector3 target = new Vector3(endPosition.x, startPosition.y + _verticalSpeed);

        Vector3 position = Vector3.MoveTowards(startPosition, target, _horizontalSpeed * Time.deltaTime);
        
        _model.SetPosition(position);
    }
}
