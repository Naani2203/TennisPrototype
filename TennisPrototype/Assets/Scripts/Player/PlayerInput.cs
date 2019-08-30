using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private FloatVariableSO _HorizontalAxis;
    [SerializeField]
    private FloatVariableSO _VerticalAxis;
    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        _HorizontalAxis.Value = Input.GetAxis("Horizontal");
        _VerticalAxis.Value = Input.GetAxis("Vertical");
    }
}
