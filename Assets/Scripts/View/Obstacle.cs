using UnityEngine;

abstract class Obstacle : Movement
{
    public virtual void Destroy()
    {
        Destroy(gameObject);
    }
}