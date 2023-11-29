using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    private Rigidbody2D rb2D;
    Vector2 dir = new Vector2(1, 1);
    [SerializeField] int startSpeed;
    
    bool isMoving = false;
    public int angleMultiplier;
    

    public GameObject paddle;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        SoltarBola();
        
    }

    void SoltarBola()
    {
        if (transform.parent != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isMoving = true;
                transform.parent = null;
                LanzarBola();
            }
        }
    }

    void LanzarBola()
    {
        rb2D.AddForce(dir * startSpeed, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathZone"))
        {
            Muerte();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.CompareTag("Paddle"))
        {
            float posDiff = paddle.transform.position.x - transform.position.x;

            Vector2 angleBounce = new Vector2(posDiff * 64,28, 0); // pasar 0,7 unidades a 45 grados

            Debug.Log(posDiff);
       
        }*/

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            float paddleWidth = collision.transform.localScale.x;

            float posDiff = paddle.transform.position.x - transform.position.x;

            float normalizedPosDiff = Mathf.Clamp(posDiff + (paddleWidth / 2) / paddleWidth, 0, 1);

            float angleBounce = Mathf.Lerp(30, 150, normalizedPosDiff);

            var bounceDir = Quaternion.AngleAxis(angleBounce, Vector3.forward);

            Vector2 newBounceDirection = bounceDir * Vector2.right * angleMultiplier;

            Vector2 newVelocity = (rb2D.velocity + new Vector2(newBounceDirection.x, newBounceDirection.y)).normalized * rb2D.velocity.magnitude;

            rb2D.velocity = newVelocity;

        }
    }

    void Muerte()
    {
        transform.SetParent(paddle.transform);
        isMoving = false;
        rb2D.velocity = new Vector2(0, 0);
        transform.localPosition = new Vector2(0, 1.2f);
        gameManager.QuitarVida();
    }

    void Empujon() //Para cuando la bola se queda "pillada" en un eje
    {
        if (isMoving == true && rb2D.velocity.y < 0.05)
        {
            
        }
    }


}
