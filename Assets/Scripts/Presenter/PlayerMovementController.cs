using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private PlayerMovementView _movementView;
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _verticalSpeed;

    public void Move(Vector3 pointerPosition)
    {
        Vector2 startPosition = transform.position;
        Vector2 endPosition = new Vector2(pointerPosition.x, transform.position.y + _verticalSpeed);

        Vector2 position = Vector2.MoveTowards(startPosition, endPosition, _horizontalSpeed * Time.deltaTime);
        _movementView.SetPosition(position);
    }
}
