using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs : MonoBehaviour
{
   
    float intervalo;
    [SerializeField] GameObject[] edificios;
    [SerializeField] Transform instantiatePos;
    [SerializeField] float distance;
    InicioJuego initGame;
    [SerializeField] float posZedificio1 = 10f;


    void Start()
    {
        distance = 40f;
        initGame = GameObject.Find("InitGame").GetComponent<InicioJuego>();
        StartCoroutine("CrearEdificios");

        Edificiosiniciales();
    }
    void Update()
    {

    }



     IEnumerator CrearEdificios()
     {
         if (initGame.alive)
         {
             float speed;
             while (true)
             {

                 speed = initGame.juegoSpeed;
                 intervalo = distance / speed;
                 float randomX = Random.Range(-18f, 18f);
                 Vector3 newPos = new Vector3(randomX, instantiatePos.position.y+5f, instantiatePos.position.z);
                 int numAl = Random.Range(0, edificios.Length);
                 Instantiate(edificios[numAl], newPos, Quaternion.identity);
                 yield return new WaitForSeconds(intervalo);

             }
         }
     }
    
    
    void Edificiosiniciales()
    {
        float posZ = transform.position.z;
        float edificiosiniciales = (posZ - posZedificio1) / distance;
        edificiosiniciales = Mathf.Round(edificiosiniciales);
        for(float n= posZedificio1; n < posZ; n += distance)
        {
            float randomX = Random.Range(-18f, 18f);
            Vector3 edificioInicialPos = new Vector3(randomX, instantiatePos.position.y+5f,n+200);
            Instantiate(edificios[1], edificioInicialPos, Quaternion.identity);

        }
    }
}
