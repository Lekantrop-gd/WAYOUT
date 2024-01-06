using UnityEngine;

public class TargetedObstacleModel : Model
{
    public Vector3 StartPosition { get; private set; }
    public Vector3 EndPosition { get ; private set; }

    public TargetedObstacleModel(View view, Vector3 startPosition, Vector3 endPosition) : base(startPosition, view) 
    { 
        StartPosition = startPosition;
        EndPosition = endPosition;
    }
}