using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseLife : PowerUp
{
    public override void Aplicar()
    {
        var gameManager = GameObject.FindGameObjectWithTag("GameManager");

        if(gameManager == null)
        {
            return;
        }

        gameManager.GetComponent<GameManager>().SumarVida();

        /*try
        {
            var gameManager = GameObject.FindGameObjectWithTag("GameManager");

            gameManager.GetComponent<GameManager>().SumarVida();
        }
        catch (Exception ex)
        {
            Debug.Log(ex);
        }*/                                                                      // Otra forma de evitar un error por null


        //gameManager?.GetComponent<GameManager>()?.SumarVida();                    Otra forma de evitar un error por null

    }
}
