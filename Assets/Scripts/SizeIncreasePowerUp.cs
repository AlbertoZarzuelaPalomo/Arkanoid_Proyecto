using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIncreasePowerUp : PowerUp
{

    // Start is called before the first frame update
    public override void Aplicar()
    {

        GameObject paddle = GameObject.FindGameObjectWithTag("Paddle");

        paddle.transform.localScale = new Vector3(2.8f, transform.localScale.y, transform.localScale.z);

    }


}
