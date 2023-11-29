using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIncreasePowerUp : PowerUp
{

    GameObject paddle;
    // Start is called before the first frame update
    public override void Aplicar()
    {

        paddle = GameObject.FindGameObjectWithTag("Paddle");

        paddle.transform.localScale = new Vector3(Mathf.Clamp(transform.localScale.x *2, 2f, 4f), transform.localScale.y, transform.localScale.z);

        Destroy(gameObject, 10f);

    }

    private void OnDestroy()
    {
        if (paddle != null)
        {
            paddle.transform.localScale = new Vector3(1.4f, 0.3f, 0f);
        }
        
    }

}
