using UnityEngine;

public class TargetedObstaclePresenter
{
    private TargetedObstacleModel _model;
    private float _speed;

    public TargetedObstaclePresenter(TargetedObstacleModel model, float speed)
    {
        _model = model;
        _speed = speed;
    }

    public void Move(Vector3 startPosition, Vector3 targetPosition)
    {
        Vector3 position = Vector3.MoveTowards(startPosition, targetPosition, _speed * Time.deltaTime);
        
        _model.SetPosition(position);
    }
}