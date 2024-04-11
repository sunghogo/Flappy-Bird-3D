using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 100f;
    [SerializeField] private float _flySpeed = 5000f;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            Fly();
        }
    }

    private void Fly() {
        _rigidbody.AddForce(Vector3.up * Time.deltaTime * _flySpeed);
    }

}
