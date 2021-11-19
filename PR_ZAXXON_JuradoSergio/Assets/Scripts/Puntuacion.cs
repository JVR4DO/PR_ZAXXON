using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public static float score;
    public Text Contador;
    float speed;
    InicioJuego initgame;
    // Start is called before the first frame update
    void Start()
    {

        score = 0;
        StartCoroutine("Puntos");
    }

    // Update is called once per frame
    void Update()
    {
        Contador.text = score.ToString(); 
    }
    IEnumerator Puntos()
    {
        while(true)
        {
            initgame = GameObject.Find("InitGame").GetComponent<InicioJuego>();
            speed = initgame.juegoSpeed;
            score = Mathf.Round(score + 0.1f * speed);
            yield return new WaitForSeconds(0.1f);

        }
    }
}
