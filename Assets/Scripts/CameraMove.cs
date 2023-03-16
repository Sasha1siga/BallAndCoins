using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Rigidbody _playerRigidbody;
    [SerializeField] List<Vector3> _velociriesList = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            _velociriesList.Add(Vector3.zero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 averageSpeed = Vector3.zero;
        for (int i = 0; i < _velociriesList.Count; i++)
        {
            averageSpeed += _velociriesList[i];
        }
        transform.position = _playerTransform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(averageSpeed), Time.deltaTime * 10);
    }
    private void FixedUpdate()
    {
        _velociriesList.Add(_playerRigidbody.velocity);
        _velociriesList.RemoveAt(0);
    }
}
