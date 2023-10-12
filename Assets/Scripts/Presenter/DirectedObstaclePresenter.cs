using UnityEngine;

class DirectedObstaclePresenter
{
    private DirectedObstacleModel _model;
    private Vector3 _targetPosition;

    public DirectedObstaclePresenter(DirectedObstacleModel model)
    {
        _model = model;
    }

    public void InitializeMove(MovementDirection _movementDirection, Vector3 startPosition, float movementDistance)
    {
        if (_movementDirection == MovementDirection.up)
        {
            _targetPosition = new Vector3(startPosition.x, startPosition.y + movementDistance, startPosition.z);
        }

        else if (_movementDirection == MovementDirection.down)
        {
            _targetPosition = new Vector3(startPosition.x, startPosition.y - movementDistance, startPosition.z);
        }

        else if (_movementDirection == MovementDirection.left)
        {
            _targetPosition = new Vector3(startPosition.x - movementDistance, startPosition.y, startPosition.z);
        }

        else if (_movementDirection == MovementDirection.right)
        {
            _targetPosition = new Vector3(startPosition.x + movementDistance, startPosition.y, startPosition.z);
        }
    }

    public void Move(Vector3 startPosition, float movementSpeed)
    {
        _model.SetPosition(Vector3.MoveTowards(startPosition, _targetPosition, Time.deltaTime * movementSpeed));
    }
}