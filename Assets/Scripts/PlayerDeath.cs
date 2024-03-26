using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        /* este script comentado lo que hace es lo siguiente cuando detecta algun
        objeto com el tag de DeathZone carga la escena de game over
         if (other.CompareTag("DeathZone"))
    {
        Debug.Log("Colisión detectada con la zona de muerte");
        SceneManager.LoadScene("GameOver");
       
    }         

    lo que hace el de aca es que cuando detecta algun objeto con el tag
    de player carga la escena de game over
    
    */
    if (other.CompareTag("Player"))
    {
        Debug.Log("Colisión ");
        SceneManager.LoadScene("GameOver");
       
    }
    }
}
