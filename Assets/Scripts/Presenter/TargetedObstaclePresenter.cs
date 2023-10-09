using UnityEngine;

public class TargetedObstaclePresenter
{
    private TargetedObstacleModel _model;

    public TargetedObstaclePresenter(TargetedObstacleModel model)
    {
        _model = model;
    }

    public void Move(Vector3 startPosition, Vector3 targetPosition, float speed)
    {
        Vector3 position = Vector3.MoveTowards(startPosition, targetPosition, speed * Time.deltaTime);
        _model.SetPosition(position);
    }
}