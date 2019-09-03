using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAim : MonoBehaviour
{
    [SerializeField]
    private TransformSO _EnemyAimTargetTransformSo;

    void Start()
    {
        _EnemyAimTargetTransformSo.Value = this.transform;
    }

 
}
