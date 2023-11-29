using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : PowerUp
{

    GameObject bola;
    Rigidbody2D bolaRB;
    int speedUp = 2;
    public override void Aplicar()
    {
        bola = GameObject.FindGameObjectWithTag("Ball");

        bolaRB = bola.GetComponent<Rigidbody2D>();

        Debug.Log("TENGO POWER UP");


        bolaRB.velocity *= speedUp;

        Destroy(gameObject, 2f);
    }

    private void OnDestroy()
    {
        if (bola != null)
        {
            bolaRB.velocity /= speedUp;
        }
        
    }

}
