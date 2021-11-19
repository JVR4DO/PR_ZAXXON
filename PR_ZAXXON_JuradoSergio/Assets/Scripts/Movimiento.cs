using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Movimiento : MonoBehaviour
{
    InicioJuego initGame;
    [SerializeField] float speed = 10f;
    float limiteH = 18f;
    float limiteV = 20f;
    float limiteV2 = 1.3f;
    bool alive;
    
    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InicioJuego>();
        alive = initGame.alive;
    }
    // Update is called once per frame
    void Update()
    {
        MovimientoCoche();
    }
    void MovimientoCoche()
        {
        if (alive)
        {
            float posY = transform.position.y;
            float desplY = Input.GetAxis("Vertical") * speed;
            if ((posY < limiteV || desplY < 0f) && (posY > limiteV2 || desplY > 0f))
            {
                transform.Translate(Vector3.up * desplY * Time.deltaTime);
            }
            float posX = transform.position.x;
            float desplX = Input.GetAxis("Horizontal") * speed;
            if ((posX < limiteH || desplX < 0f) && (posX > -limiteH || desplX > 0f))
            {
                transform.Translate(Vector3.right * desplX * Time.deltaTime);
            }
        }
        if ( Input.GetButtonDown("Fire1"))
        {
            //Hacer animacion
        }

        }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Edificio")
        {
            InicioJuego inicioJuego = GameObject.Find("InitGame").GetComponent<InicioJuego>();
            inicioJuego.SendMessage("Morir");
            
        }
    }






}
