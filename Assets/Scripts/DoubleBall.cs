using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBall : PowerUp
{
    GameObject bola;
    Rigidbody2D bolaRB;

    public override void Aplicar()
    {

        bola = GameObject.FindGameObjectWithTag("Ball");

        bolaRB = bola.GetComponent<Rigidbody2D>();

        Vector3 posicionBola = bola.transform.position;

        GameObject nuevaBola = Instantiate(bola, posicionBola, Quaternion.AngleAxis(90, Vector3.forward));

    }

}
