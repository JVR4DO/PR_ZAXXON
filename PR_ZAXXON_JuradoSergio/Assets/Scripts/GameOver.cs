using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    InicioJuego initgame;
    [SerializeField] GameObject gameOver;
    void Start()
    {
        initgame = GameObject.Find("InitGame").GetComponent<InicioJuego>();
        PantallaMuerte();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PantallaMuerte()
    {
        if (initgame.alive == true)
        {
            GameObject.Find("GameOverImage").SetActive(false);
        }
        else
        {
            GameObject.Find("GameOverImage").SetActive(true);
        }
     }

        
    
        
   }

