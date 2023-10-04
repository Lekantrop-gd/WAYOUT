using UnityEngine;

public class CameraMovementModel
{
    private View _view;
    private Vector3 _position;

    public CameraMovementModel(View view, Vector3 position)
    {
        _view = view;
        _position = position;
    }

    public void SetPosition(Vector3 position)
    {
        _position = position;
        _view.SetPosition(_position);
    }
}
