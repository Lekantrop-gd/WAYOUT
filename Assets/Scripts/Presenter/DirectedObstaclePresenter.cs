using UnityEngine;

class DirectedObstaclePresenter
{
    private DirectedObstacleModel _model;
    private MovementDirection _movementDirection;
    private float _movementDistance;
    private Vector3 _targetPosition;
    private bool _isLooped;

    public DirectedObstaclePresenter(DirectedObstacleModel model)
    {
        _model = model;
    }

    public void InitializeMovement(MovementDirection movementDirection, Vector3 startPosition, float movementDistance, bool isLooped)
    {
        _movementDirection = movementDirection;
        _movementDistance = movementDistance;
        _isLooped = isLooped;

        if (_movementDirection == MovementDirection.up)
            _targetPosition = new Vector3(startPosition.x, startPosition.y + movementDistance, startPosition.z);

        else if (_movementDirection == MovementDirection.down)
            _targetPosition = new Vector3(startPosition.x, startPosition.y - movementDistance, startPosition.z);

        else if (_movementDirection == MovementDirection.left)
            _targetPosition = new Vector3(startPosition.x - movementDistance, startPosition.y, startPosition.z);

        else if (_movementDirection == MovementDirection.right)
            _targetPosition = new Vector3(startPosition.x + movementDistance, startPosition.y, startPosition.z);
    }

    public void Move(Vector3 startPosition, float movementSpeed)
    {
        if (_isLooped)
        {
            if (startPosition == _targetPosition)
            {
                if (_movementDirection == MovementDirection.up)
                    InitializeMovement(MovementDirection.down, startPosition, movementSpeed, _isLooped);
                
                else if (_movementDirection == MovementDirection.down)
                    InitializeMovement(MovementDirection.up, startPosition, movementSpeed, _isLooped);
                
                else if (_movementDirection == MovementDirection.left)
                    InitializeMovement(MovementDirection.right, startPosition, movementSpeed, _isLooped);
                
                else if (_movementDirection == MovementDirection.right)
                    InitializeMovement(MovementDirection.left, startPosition, movementSpeed, _isLooped);
            }
        }

        _model.SetPosition(Vector3.MoveTowards(startPosition, _targetPosition, Time.deltaTime * movementSpeed));
    }
}