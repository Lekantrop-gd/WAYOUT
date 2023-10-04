using UnityEngine;

public class CameraMovementPresenter
{
    private CameraMovementModel _model;

    public CameraMovementPresenter(CameraMovementModel model)
    {
        _model = model;
    }

    public void Move(Vector3 cameraPosition, Vector3 playerPosition, float offset, float speed)
    {
        Vector3 startPosition = cameraPosition;
        Vector3 endPosition = new Vector3(startPosition.x, playerPosition.y - offset, startPosition.z);
        
        Vector3 position = Vector3.MoveTowards(startPosition, endPosition, speed * Time.deltaTime);
        _model.SetPosition(position);
    }
}
