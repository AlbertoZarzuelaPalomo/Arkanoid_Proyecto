using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIncreasePowerUp : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tengo el potenciador");

        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y, transform.localScale.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paddle"))
        {
            
        }
    }*/


}
