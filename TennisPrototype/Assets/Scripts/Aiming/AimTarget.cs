using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTarget : MonoBehaviour
{
    [SerializeField]
    private FloatVariableSO _RHorizontalAxis;
    [SerializeField]
    private FloatVariableSO _RVerticalAxis;
    [SerializeField]
    private TransformSO _AimTransform;
    [SerializeField]
    private float _AimSpeed;
    private Vector3 _InitialPos;

    private void Start()
    {
        _InitialPos = transform.position;
        _AimTransform.Value = this.transform;

    }


    void Update()
    {
        if (_RHorizontalAxis.Value != 0)
        {
            transform.Translate(new Vector3( 0, 0, -_RHorizontalAxis.Value).normalized * _AimSpeed * Time.deltaTime);
        }
        else
            transform.position = Vector3.Lerp(transform.position, _InitialPos,0.3f);
    }
}
