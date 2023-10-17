using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TailView : View
{
    [SerializeField] private Transform _joint;
    [SerializeField] private int _tailLenght;
    [SerializeField] private float _targetDistance;
    [SerializeField] private float _smoothSpeed;

    private LineRenderer _lineRenderer;
    
    private Vector3[] _tailPoses;
    private Vector3[] _tailVelocity;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = _tailLenght;
<<<<<<< HEAD
        _tailVelocity = new Vector3[_tailLenght];
        _tailPoses = new Vector3[_tailLenght];
    }

    public void AddTailElement(int tailLenght)
    {
        _tailLenght = tailLenght;
        _lineRenderer.positionCount = _tailLenght;
        _tailVelocity = new Vector3[_tailLenght];
        _tailPoses = new Vector3[_tailLenght];
=======
        _tailPoses = new Vector3[_tailLenght];
        _tailVelocity = new Vector3[_tailLenght];
>>>>>>> parent of 4ce7a6b (A lot of different sh*t)
    }

    private void Update()
    {
        _tailPoses[0] = _joint.position;

        for (int i = 1; i < _tailPoses.Length; i++)
        {
            _tailPoses[i] = Vector3.SmoothDamp(_tailPoses[i], _tailPoses[i - 1] + _joint.right * _targetDistance, ref _tailVelocity[i], _smoothSpeed);
        }

        _lineRenderer.SetPositions(_tailPoses);
    }
}
