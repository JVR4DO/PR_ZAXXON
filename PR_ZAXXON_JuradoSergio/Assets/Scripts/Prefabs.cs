using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs : MonoBehaviour
{
    /*
    [SerializeField] GameObject edificioPrefab;
    [SerializeField] Transform initPos;
    float desplX = 1f;*/
    float intervalo;
    [SerializeField] GameObject edificio;
    [SerializeField] Transform instantiatePos;
    


    void Start()
    {
        
        /*
         * Crear bloques
        Vector3 destPos = initPos.position;
        Vector3 despl = new Vector3(desplX, 0,0);

        for (int n = 0; n < 10; n++)
        {
            Instantiate(edificioPrefab, destPos, Quaternion.identity);
            destPos = destPos + despl;
        }*/
        intervalo = 1f;

        StartCoroutine("CrearEdificio");

    }
     void Update()
    {
       
    }



    IEnumerator CrearEdificio()
        {
            while (true)
            {
                float randomX = Random.Range(-18f, 18f);
                Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
                Instantiate(edificio, newPos, Quaternion.identity);
                yield return new WaitForSeconds(intervalo);
            }

        }
    }

