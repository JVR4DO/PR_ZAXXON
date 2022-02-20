using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    //Variables necesarias para la opción de suavizado
    [SerializeField] float smoothVelocity = 0.2F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y+2.37f, playerPosition.position.z-7f);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);

    }
 
}
