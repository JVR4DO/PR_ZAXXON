using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEdificio : MonoBehaviour
{
    float speed;
    InicioJuego initGame;

    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InicioJuego>();

        speed = initGame.juegoSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        speed = initGame.juegoSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        float posZ = transform.position.z;
        if (posZ < -20)
        {
            Destroy(gameObject);
        }
    }
}
