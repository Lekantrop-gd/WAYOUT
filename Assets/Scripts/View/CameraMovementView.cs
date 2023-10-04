using UnityEngine;

public class CameraMovementView : View
{
    [SerializeField] private View _player;
    [SerializeField] private float _offset;
    [SerializeField] private float _speed;

    private CameraMovementModel _model;
    private CameraMovementPresenter _presenter;

    private void Awake()
    {
        _model = new CameraMovementModel(this, transform.position);
        _presenter = new CameraMovementPresenter(_model);
    }

    private void Update()
    {
        _presenter.Move(transform.position, _player.transform.position, _offset, _speed);
    }
}
