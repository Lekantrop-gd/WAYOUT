using UnityEngine;

public class PlayerMovementView : Movement
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}