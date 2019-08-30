using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO", menuName = "ScriptableObj/RigidBodySO")]
public class RigidBodySO : ScriptableObject
{
    public Rigidbody Value;
}
