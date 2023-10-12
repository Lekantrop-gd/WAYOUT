using UnityEngine;
using UnityEngine.UIElements;

public class TargetedObstacleModel : ObstacleModel
{
    private Vector3 _startPosition;
    private Vector3 _endPosition;

    public TargetedObstacleModel(Vector3 positoin, View view) : base(positoin, view)
    {
    }

    public Vector3 StartPosition { get => _startPosition; }
    public Vector3 EndPosition { get => _endPosition; }
}