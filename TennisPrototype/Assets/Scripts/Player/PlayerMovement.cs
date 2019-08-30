using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Scriptable Objects")]
    [SerializeField]
    private FloatVariableSO _HorizontalAxis;
    [SerializeField]
    private FloatVariableSO _VerticalAxis;

    [Header("Player")]
    [SerializeField]
    private float _MovementSpeed;
    [SerializeField]
    private float _MaxSpeed;
    [SerializeField]
    private Rigidbody _Rb;
    private Vector3 _Direction;
    
  
    void Update()
    {
        if(_HorizontalAxis.Value!=0||_VerticalAxis.Value!=0)
        { 
            if(_Rb.velocity.magnitude < _MaxSpeed)
                _Rb.AddForce(new Vector3(_VerticalAxis.Value, 0, -_HorizontalAxis.Value) * _MovementSpeed);
            
        }
        else
        {
            _Rb.velocity = Vector3.zero;
        }
    }
}
