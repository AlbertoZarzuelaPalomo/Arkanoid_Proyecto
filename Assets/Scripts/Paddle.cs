using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [Header("Características")]
    [SerializeField]
    private float speed;
    private float leftBound = -4f;
    private float rightBound = 4f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        MovePaddle();
    }

    private void MovePaddle()
    {
        float h = (Input.GetAxisRaw("Horizontal"));

        float x = Mathf.Clamp(transform.position.x + (h * Time.deltaTime * speed), leftBound, rightBound);

        Vector3 vector2 = new Vector2(x, transform.position.y);

        transform.position = vector2;
    }

}
