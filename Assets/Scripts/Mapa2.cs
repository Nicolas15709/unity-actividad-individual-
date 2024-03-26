using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Mapa2 : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
    {
        
        // este tag es para el player cuando se lance el trigger va a detectar el tag del objeto en este caso tiene que ser player
         if (other.CompareTag("Player"))
    {
        Debug.Log("Colisión detectada con la zona de muerte");
        SceneManager.LoadScene("Principal2");
       
    }         


   /*
    solo debe haber uno par que funcion bien si quieres hacer solo un scrip
    para tener varios tienes que declarar unas variables como la logica
    para hacer if en caso de estar en cada nivel 
    if (other.CompareTag("Player"))
    {
        Debug.Log("Colisión ");
        SceneManager.LoadScene("Principal2");
       
    }
    */
    }
}

