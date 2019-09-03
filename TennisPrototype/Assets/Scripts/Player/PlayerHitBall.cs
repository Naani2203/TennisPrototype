using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBall : MonoBehaviour
{
    [SerializeField]
    private Animator _Anim;
    [SerializeField]
    private TransformSO _AimTransform;
    [SerializeField]
    private RigidBodySO _BallRigidbody;
    [SerializeField]
    private FloatVariableSO _BallHeight;
    [SerializeField]
    private FloatVariableSO _BallSpeed;
    [SerializeField]
    private TransformSO _BallTransformSO;
    private Vector3 _Direction;
    private Vector3 _BallDir;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            _Direction = transform.position - _AimTransform.Value.position;
            _BallRigidbody.Value.velocity = Vector3.zero;
            _BallRigidbody.Value.AddForce(new Vector3(_Direction.x,_BallHeight.Value,_Direction.z)* -_BallSpeed.Value );

            _BallDir = _BallTransformSO.Value.position - transform.position;
            if (_BallDir.z <= 0)
                _Anim.Play("Forehand");
            else
                _Anim.Play("Backhand");
        }
    }
}
