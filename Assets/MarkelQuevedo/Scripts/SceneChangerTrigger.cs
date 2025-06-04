using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerTrigger : MonoBehaviour
{
    [SerializeField] private GameObject confirmationCanvas; // El Canvas de confirmaci�n
    [SerializeField] private string sceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activa el Canvas de confirmaci�n al detectar la colisi�n
            confirmationCanvas.SetActive(true);
            // Pasa el nombre de la escena al Canvas para saber cu�l cargar
            confirmationCanvas.GetComponent<ConfirmationCanvas>().SetSceneToLoad(sceneToLoad);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            confirmationCanvas.SetActive(false);

        }
    }
}