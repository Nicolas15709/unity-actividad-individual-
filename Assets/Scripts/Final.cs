using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        // este tag es para el player cuando se lance el trigger va a detectar el tag del objeto en este caso tiene que ser player
         if (other.CompareTag("Player"))
    {
        Debug.Log("Colisión detectada con la zona de muerte");
        SceneManager.LoadScene("Final");
       
    }   
    }
}