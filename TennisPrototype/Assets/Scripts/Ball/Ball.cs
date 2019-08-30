using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private VectorSO _BallDirectionSO;
    [SerializeField]
    private FloatVariableSO _BallHeightSO;
    [SerializeField]
    private FloatVariableSO _BallSpeedSO;
    [SerializeField]
    private RigidBodySO _BallRigidbodySO;
    [SerializeField]
    private TransformSO _PlayerTransformSO;

    private void Start()
    {
        _BallRigidbodySO.Value = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            _BallRigidbodySO.Value.velocity = Vector3.zero;
            _BallRigidbodySO.Value.AddForce((transform.position - _PlayerTransformSO.Value.position) * _BallSpeedSO.Value + new Vector3(0, _BallHeightSO.Value, 0));
            Debug.Log("Works");
        }
    }


}
