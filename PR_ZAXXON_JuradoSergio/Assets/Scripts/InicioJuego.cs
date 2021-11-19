using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InicioJuego : MonoBehaviour
{
    public float juegoSpeed;
    public bool alive;
    public float obstacleDistance = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
        alive = true;
        juegoSpeed = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            juegoSpeed += 0.005f;
            
        }
    }
    public void Morir()
    {
        juegoSpeed = 0f;
        alive = false;
        GameObject.Find("Coche Padre").SetActive(false);
        
    }

    
}
