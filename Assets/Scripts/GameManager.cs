using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int vidas;
    private int puntuacion;

    List<GameObject> totalBricks;

    public int Vidas { get { return this.vidas; } }
    public int Puntuacion {  get { return this.puntuacion; } }

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitarVida()
    {
        vidas -= 1;
    }

    public void SumarPuntos(int puntosBloque)
    {
        puntuacion += puntosBloque;
    }
}
