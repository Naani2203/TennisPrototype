using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private FloatVariableSO _HorizontalAxis;
    [SerializeField]
    private FloatVariableSO _VerticalAxis;
    [SerializeField]
    private FloatVariableSO _RHorizontalAxis;
    [SerializeField]
    private FloatVariableSO _RVerticalAxis;
    [SerializeField]
    private TransformSO _PlayerTransform;
    
    private void Start()
    {
        SetValue();
        
    }
    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        _HorizontalAxis.Value = Input.GetAxis("Horizontal");
        _VerticalAxis.Value = Input.GetAxis("Vertical");
        _RHorizontalAxis.Value = Input.GetAxis("RHorizontal");
        _RVerticalAxis.Value = Input.GetAxis("RVertical");
    }

    private void SetValue()
    {
        _PlayerTransform.Value = this.transform;
    }
}
