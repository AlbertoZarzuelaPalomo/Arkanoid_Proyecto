using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int vidas;
    private int puntuacion;

    List<GameObject> totalBricks;
    List<GameObject> bricksWithPowerUps;

    [SerializeField]
    private List<PowerUp> potenciadoresDisponibles;

    public int Vidas { get { return this.vidas; } }
    public int Puntuacion {  get { return this.puntuacion; } }

    private void Awake()
    {
        totalBricks = GameObject.FindGameObjectsWithTag("Brick").ToList();

        //Debug.Log("Hay " + totalBricks + " en escena");

        bricksWithPowerUps = totalBricks
            .OrderBy(x => Random.value)
            .Take(4)
            .ToList();

        foreach(GameObject ladrillo in bricksWithPowerUps)
        {
            var ladrilloScript = ladrillo.GetComponent<Brick>();

            var miGameObject = new GameObject();
            miGameObject.AddComponent<DoubleBall>();
            ladrilloScript.MiPotenciador = miGameObject;
                
            
            //ladrillo.GetComponent<Brick>().Potenciador = new SizeIncreasePowerUp();       Sin heredar de mono behaviour
        }
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
        vidas--;
    }

    public void SumarVida()
    {
        vidas++;
    }

    public void SumarPuntos(int puntosBloque)
    {
        puntuacion += puntosBloque;
    }
}
