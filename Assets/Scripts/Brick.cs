using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject paddle;
    public Rigidbody2D ballRB;

    [SerializeField] GameManager gameManager;

    
    public GameObject MiPotenciador;

    
    SpriteRenderer spriteRenderer;
    [SerializeField] int lifes;
    [SerializeField] int puntos;
    
    
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
        lifes--;

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
            ballRB.velocity *= speeding;

            gameManager.SumarPuntos(puntos);

            //paddle.gameObject.AddComponent<SizeIncreasePowerUp>();

            if (MiPotenciador != null)
            {

                MiPotenciador.GetComponent<PowerUp>().Aplicar();

            }

            Destroy(gameObject);
        }
    }
}
