using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DirectedObstacleView : ObstacleView
{
    [SerializeField] private bool _isMoveable;
    [SerializeField] private bool _isLooped;
    [SerializeField] private MovementDirection _movementDirection;
    [SerializeField] private float _movementDistance;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _delay;

    private DirectedObstaclePresenter _presenter;
    private DirectedObstacleModel _model;

    private void Awake()
    {
        _model = new DirectedObstacleModel(transform.position, this);
        _presenter = new DirectedObstaclePresenter(_model);
        _presenter.InitializeMovement(_movementDirection, transform.position, _movementDistance, _isLooped);
    }

    private IEnumerator StartMovement()
    {
        yield return new WaitForSeconds(_delay);
        while (true)
        {
            _presenter.Move(transform.position, _movementSpeed);
            yield return null;
        }
    }

    private void OnBecameVisible()
    {
        if (_isMoveable)
        {
            StartCoroutine(StartMovement());
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Collider2D collider = GetComponent<Collider2D>();
        
        if (collider != null && _isMoveable)
        {
            if (_movementDirection == MovementDirection.up)
                Gizmos.DrawWireCube(new Vector2(transform.position.x, transform.position.y + _movementDistance), collider.bounds.size);
            
            if (_movementDirection == MovementDirection.down)
                Gizmos.DrawWireCube(new Vector2(transform.position.x, transform.position.y - _movementDistance), collider.bounds.size);
            
            if (_movementDirection == MovementDirection.right)
                Gizmos.DrawWireCube(new Vector2(transform.position.x + _movementDistance, transform.position.y), collider.bounds.size);
            
            if (_movementDirection == MovementDirection.left)
                Gizmos.DrawWireCube(new Vector2(transform.position.x - _movementDistance, transform.position.y), collider.bounds.size);
        }
        
    }
}