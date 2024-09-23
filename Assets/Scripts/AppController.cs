using UnityEngine;
using UnityEngine.SceneManagement;

public class AppController : MonoBehaviour
{
    // Função para sair do aplicativo
    public void ExitApp()
    {
        Debug.Log("Sair do aplicativo.");
        
        // Funciona apenas em builds, não no editor do Unity
        Application.Quit();
    }

    // Função para reiniciar a cena atual
    public void RestartApp()
    {
        Debug.Log("Reiniciando o aplicativo.");
        
        // Carrega a cena atual novamente
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
