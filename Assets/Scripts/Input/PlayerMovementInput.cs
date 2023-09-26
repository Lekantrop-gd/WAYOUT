using UnityEngine;

public class PlayerMovementInput : MonoBehaviour
{
    [SerializeField] private PlayerMovementController _movementController;

    private void Update()
    {
        Vector3 pointerPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _movementController.Move(pointerPosition);
    }
}
