using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBall : MonoBehaviour
{
    [SerializeField]
    private TransformSO _AimTransform;
    [SerializeField]
    private RigidBodySO _BallRigidbody;
    [SerializeField]
    private FloatVariableSO _BallHeight;
    [SerializeField]
    private FloatVariableSO _BallSpeed;
    private Vector3 _Direction;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            _Direction = transform.position - _AimTransform.Value.position;
            _BallRigidbody.Value.velocity = Vector3.zero;
            _BallRigidbody.Value.AddForce(new Vector3(_Direction.x,_BallHeight.Value,_Direction.z)* -_BallSpeed.Value );
        }
    }
}
