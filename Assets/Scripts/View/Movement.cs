using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    public virtual void SetPosition(Vector3 position) 
    {
        transform.position = position;
    }
}
