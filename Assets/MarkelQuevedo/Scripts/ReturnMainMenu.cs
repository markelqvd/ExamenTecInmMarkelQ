using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    // M�todo que se llama cuando se hace clic en el bot�n
    public void LoadMainMenu()
    {
       
        SceneManager.LoadScene("Menu");
    }
}
