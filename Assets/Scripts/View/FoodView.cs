using UnityEngine;

public class FoodView : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerMovementView>();
        if (player == true)
        {
            var tail = collision.transform.GetChild(0).GetComponent<TailView>();
            tail.Initialize(tail.TailLenght + 1);
            Destroy(gameObject);
        }
    }
}
