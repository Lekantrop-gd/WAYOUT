﻿using UnityEngine;

public class View : MonoBehaviour
{
    public virtual void UpdateView(Vector3 position)
    {
        transform.position = position;
    }
}