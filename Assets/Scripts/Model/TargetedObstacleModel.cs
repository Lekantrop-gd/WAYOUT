using UnityEngine;

public class TargetedObstacleModel
{
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private Vector3 _position;
    private View _view;

    public TargetedObstacleModel(Vector3 startPosition, Vector3 endPosition, View view)
    {
        _startPosition = startPosition;
        _endPosition = endPosition;
        _view = view;
    }

    public Vector3 StartPosition { get => _startPosition; }
    public Vector3 EndPosition { get => _endPosition; }

    public void SetPosition(Vector3 position)
    {
        _position = position;
        _view.UpdateView(position);
    }
}