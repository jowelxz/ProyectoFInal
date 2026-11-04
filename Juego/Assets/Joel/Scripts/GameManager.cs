using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelGanaste;
    public GameObject panelPerdiste;

    public GameObject panelPausa;

    public void MostrarPausa()
    {
        panelPausa.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReanudarJuego()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MostrarPerdiste()
    {
        panelPerdiste.SetActive(true);
        Time.timeScale = 0f;
    }

    public void MostrarGanaste()
    {
        panelGanaste.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReiniciarNivel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SalirDelJuego()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}