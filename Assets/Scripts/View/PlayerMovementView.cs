using UnityEngine;

public class PlayerMovementView : View
{
    [SerializeField] private float _verticalSpeed;
    [SerializeField] private float _horizontalSpeed;

    private PlayerMovementModel _model;
    private PlayerMovementPresenter _presenter;

    private void Awake()
    {
        _model = new PlayerMovementModel(this, transform.position);
        _presenter = new PlayerMovementPresenter(_model);
    }

    private void Update()
    {
        Vector3 pointerPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _presenter.Move(pointerPosition, transform.position, _verticalSpeed, _horizontalSpeed);
    }
}