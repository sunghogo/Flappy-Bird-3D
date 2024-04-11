using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] private float _gravity = 9.81f;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private float _flySpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FallDown();
        if (Input.GetKey(KeyCode.Space)) {
            FlyUp();
        }
    }

    private void FallDown() {
        Gravity();
        RotateDown();
    }

    private void Gravity() {
        transform.position = transform.position - new Vector3(0, 1, 0) * Time.deltaTime * _gravity;
    }

    private void RotateDown() {
        transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * _rotationSpeed); // Extra Credit    
    }

    private void FlyUp() {
        Fly();
        RotateUp();
    }

    private void Fly() {
        transform.position = transform.position + new Vector3(0, 2, 0) * Time.deltaTime * _flySpeed;
    }

    private void RotateUp() {
        transform.Rotate(new Vector3(-2, 0, 0) * Time.deltaTime * _rotationSpeed); // Extra Credit    
    }
}
