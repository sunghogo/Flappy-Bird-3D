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
            RotateUp();
            Fly();
        }
    }

    private void FixedUpdate() {
        RotateDown();
    }

    // Can't properly check negative/full positive ranges 
    private void RotateDown() {
        if ((0 <= transform.eulerAngles.x && transform.eulerAngles.x <= 30) || (-30 <= transform.eulerAngles.x && transform.eulerAngles.x <= 0))
            transform.eulerAngles += new Vector3(1, 0, 0);
        else if (30 < transform.eulerAngles.x && transform.eulerAngles.x < 33)
            transform.eulerAngles = new Vector3(30, 0, 0);
    }

    private void RotateUp() {
            transform.eulerAngles = new Vector3(0, 0, 0);
    }

    private void Fly() {
        _rigidbody.AddForce(Vector3.up * Time.deltaTime * _flySpeed);

    }

}
