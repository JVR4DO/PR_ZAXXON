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
        
    }
}
