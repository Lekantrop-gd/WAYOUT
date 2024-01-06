using UnityEngine;

public class CameraPresenter
{
    private CameraModel _model;

    public CameraPresenter(CameraModel model)
    {
        _model = model;
    }

    public void Move(Vector3 startPosition, Vector3 playerPosition, float offset, float speed)
    {
        Vector3 endPosition = new Vector3(startPosition.x, playerPosition.y - offset, startPosition.z);
        
        Vector3 target = Vector3.MoveTowards(startPosition, endPosition, speed * Time.deltaTime);
        _model.SetPosition(target);
    }
}
