using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float limiteH = 18f;
    float limiteV = 20f;
    float limiteV2 = 0f;
    // Start is called before the first frame update




    
    void Start()
    {
        
        




    }

    // Update is called once per frame
    void Update()
    {
        MovimientoCoche();

    }
    void MovimientoCoche()
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
            /*
        * Otra manera de hacerlo
       if(posX > limiteH && desplX > 0f )
       {
           transform.position = new Vector3(posX, transform.position.y, transform.position.z);

       }
       else if(posX < -limiteH && desplX <0f)
       {
           transform.position = new Vector3(posX, transform.position.y, transform.position.z);
       } */
        }

    
    
     




}
