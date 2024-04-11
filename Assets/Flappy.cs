using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] private float _gravity = 9.81f;
    [SerializeField] private float _rotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Falling();
    }

    private void Falling() {
        transform.position = transform.position - new Vector3(0, 1, 0) * Time.deltaTime * _gravity;    
    }
}
