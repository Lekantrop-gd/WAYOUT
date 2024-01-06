using UnityEngine;

public class CameraView : View
{
    [SerializeField] private View _player;
    [SerializeField] private float _offset;
    [SerializeField] private float _speed;

    private CameraModel _model;
    private CameraPresenter _presenter;

    private void Awake()
    {
        _model = new CameraModel(transform.position, this);
        _presenter = new CameraPresenter(_model);
    }

    private void Update()
    {
        _presenter.Move(transform.position, _player.transform.position, _offset, _speed);
    }

    private void OnDrawGizmos()
    {
        Camera camera = Camera.main;
        float halfHeight = camera.orthographicSize;
        float halfWidth = camera.aspect * halfHeight;
        Gizmos.DrawWireCube(transform.position, new Vector3(transform.position.x + halfWidth * 2, transform.position.y / 0));
    }
}
