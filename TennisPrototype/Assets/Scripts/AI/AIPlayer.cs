using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : MonoBehaviour
{
    [SerializeField]
    private TransformSO _BallTransformSo;
    [SerializeField]
    private float _AISpeed;
    private Vector3 _TargetPosition;

    private void Start()
    {
        _TargetPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        AIMove();
    }
   private void AIMove()
    {
        _TargetPosition.z = _BallTransformSo.Value.position.z;
        transform.position = Vector3.MoveTowards(transform.position, _TargetPosition, _AISpeed * Time.deltaTime);
    }
}
