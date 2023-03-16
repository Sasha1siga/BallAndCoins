using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Transform _cameraCenterTransform;
    [SerializeField] private float TorqueValue;
    
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = 500;
    }

    void FixedUpdate()
    {
        _rigidbody.AddTorque(_cameraCenterTransform.right * Input.GetAxis("Vertical") * TorqueValue, ForceMode.Acceleration);
        _rigidbody.AddTorque(-_cameraCenterTransform.forward * Input.GetAxis("Horizontal") * TorqueValue, ForceMode.Acceleration);
;    }
}
