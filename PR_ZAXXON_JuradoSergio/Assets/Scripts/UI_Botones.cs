using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UI_Botones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cargarescenajuego()
    {
        SceneManager.LoadScene(1); 
    }
    public void cargarescenaopciones()
    {
        SceneManager.LoadScene(2);
    }
    public void cargarescenainicio()
    {
        SceneManager.LoadScene(0);
    }
    public void cargarescenahighscores()
    {
        SceneManager.LoadScene(3);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
