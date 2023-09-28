using UnityEngine;

public class PlayerMovementView : MovementView
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}