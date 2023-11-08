using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Rigidbody2D ballRB;
    
    SpriteRenderer spriteRenderer;
    [SerializeField] int lifes;
    [SerializeField] bool hasPowerUp;
    [SerializeField] GameObject[] powerUps;
    float speeding = 1.05f;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        /*switch (lifes)
        {
            case 1:
                spriteRenderer.color = Color.white;
                break;

            case 2:
                spriteRenderer.color = Color.yellow;
                break;

            case 3:
                spriteRenderer.color = Color.red;
                break;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        lifes -= 1;

        switch (lifes)
        {
            case 1:
                spriteRenderer.color = Color.white;
                break;

            case 2:
                spriteRenderer.color = Color.yellow;
                break;
        }

        if (lifes <= 0)
        {
            if (hasPowerUp)
            {
                Instantiate(powerUps[Random.Range(0, 2)]);
            }

            ballRB.velocity *= speeding;

            Destroy(gameObject);
        }
    }
}
