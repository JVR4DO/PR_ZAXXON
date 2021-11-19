using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InicioJuego : MonoBehaviour
{
    [SerializeField] GameObject GameOverCanvas;
    public float juegoSpeed;
    public bool alive;
    public float obstacleDistance = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        alive = true;
        juegoSpeed = 60f;
        GameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            juegoSpeed += 0.005f;
            
        }
    }
    void PantallaMuerte()
    {
        GameOverCanvas.SetActive(true);
    }
    public void Morir()
    {
        juegoSpeed = 0f;
        alive = false;
        GameObject.Find("Coche Padre").SetActive(false);
        Invoke("PantallaMuerte", 2f);
    }
  

}
